using System.Text.RegularExpressions;
using WLED_Pixel_Art_Generator.api;
using WLED_Pixel_Art_Generator.forms;
using WLED_Pixel_Art_Generator.util;

namespace WLED_Pixel_Art_Generator
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public string VersionNumber = "v1.0";
        private bool _presetSaved;

        private Bitmap _imageBitmap;
        private List<GridPixel> _gridPixelList = new List<GridPixel>();
        private bool _useHex;
        private bool _serpentine;
        private bool _includeOnBright;
        private bool _pythonTab;
        private bool _hassTab;
        private bool _bulkHass;
        private bool _pythonGen;
        private string _brightness;
        private string _wledUrl;
        private string _uploadedImageName;
        private AppSaveData _data;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            generateBtn.Enabled = false;
            LoadData();
            _useHex = hexCheckBox.Checked;
            _serpentine = serpCheckBox.Checked;
            _includeOnBright = onBrightCheckbox.Checked;
            _pythonTab = enablePythonModeToolStripMenuItem.Checked;
            _hassTab = enableHomeAssistantToolStripMenuItem.Checked;
            _bulkHass = false;
            hassBulkCheckbox.Checked = false;
            _pythonGen = false;
            mainTabCopyBtn.Visible = false;
            pythonTabCopyBtn.Visible = false;
            hassTabCopyBtn.Visible = false;

            ShowPythonTab(_pythonTab);
            ShowPythonListTab(false);
        }

        private void LoadData()
        {
            AppSaveData data = AppDataUtil.LoadSaveData();
            _wledUrl = data.WledIp;
            hexCheckBox.Checked = data.UseHex;
            onBrightCheckbox.Checked = data.UseOnBright;
            serpCheckBox.Checked = data.Serpentine;
            brightText.Text = data.Brightness.ToString();
            enablePythonModeToolStripMenuItem.Checked = data.UsePython;
            enableHomeAssistantToolStripMenuItem.Checked = data.UseHass;

            _data = data;
        }

        private void HandleImageSelection()
        {
            imageBox.Height = 16;
            imageBox.Width = 16;

            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

            Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
            _uploadedImageName = openFileDialog1.SafeFileName;
            _imageBitmap = bitmap;

            if (!ValidImage(_imageBitmap))
            {
                MessageBox.Show("Sorry, only images that are 16 x 16px are supported at this time.");
                return;
            }
            Image uploadedImage = bitmap.GetThumbnailImage(16, 16, myCallback, IntPtr.Zero);

            imageBox.Image = uploadedImage;

            generateBtn.Enabled = true;
            selectFileBtn.Enabled = false;
        }

        private void AddBulkImages(string fileName)
        {
            _uploadedImageName = Path.GetFileName(fileName);
            Bitmap bitmap = new Bitmap(fileName);
            _imageBitmap = bitmap;

            if (!ValidImage(_imageBitmap))
            {
                MessageBox.Show("Sorry, only images that are 16 x 16px are supported at this time.");
                return;
            }
            Generate();
            if (_bulkHass)
            {
                SendToHassTab();
            } else
            {
                SendToPythonGenerator();
                pythonProgressBar.PerformStep();
            }
            ResetForBulk();

        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private bool ValidImage(Bitmap bitmap)
        {
            return _imageBitmap.Width == 16 && _imageBitmap.Height == 16;
        }

        private void Generate()
        {
            int counter = 0;

            if (_serpentine)
            {
                for (int y = 0; y < _imageBitmap.Height; y++)
                {
                    for (int x = 0; x < _imageBitmap.Width; x++)
                    {
                        Color pixel = _imageBitmap.GetPixel(x, y);
                        SetupMatrix(counter, pixel);
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < _imageBitmap.Width; i++)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = 0; j < _imageBitmap.Height; j++)
                        {
                            Color pixel = _imageBitmap.GetPixel(i, j);
                            SetupMatrix(counter, pixel);
                            counter++;
                        }
                    }
                    else
                    {
                        for (int j = 15; j >= 0; j--)
                        {
                            Color pixel = _imageBitmap.GetPixel(i, j);
                            SetupMatrix(counter, pixel);
                            counter++;
                        }
                    }
                }
            }

            ConsolidateAndOutput();
            _imageBitmap.Dispose();
        }

        private string ConvertToHex(Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void SetupMatrix(int current, Color pixel)
        {
            GridPixel gridPixel = new GridPixel
            {
                id = current,
                hexCode = ConvertToHex(pixel)
            };

            _gridPixelList.Add(gridPixel);
        }

        private void ConsolidateAndOutput()
        {
            Dictionary<int, string> pixelDict = new Dictionary<int, string>();

            foreach (var pixel in _gridPixelList)
            {
                pixelDict.Add(pixel.id, pixel.hexCode);
            }

            int firstKey = 0;
            int lastKey = 0;
            string hexCode = "";
            string output = "{\"seg\":{\"id\":0,\"m12\":0,\"i\":[";

            if (_includeOnBright)
            {
                output = $"{{\"on\":true,\"bri\":{_brightness},\"seg\":{{\"id\":0,\"m12\":0,\"i\":[";
            }


            foreach (var pair in pixelDict)
            {
                int nextKey = pair.Key + 1;
                
                // No need to set black pixels from off state.
                if (pixelDict.ContainsKey(nextKey))
                {
                    if (pair.Value == "000000")
                    {
                        continue;
                    }

                }
                if (pixelDict.ContainsKey(nextKey) && pair.Value == pixelDict[nextKey])
                {
                    if (firstKey == 0)
                    {
                        firstKey = pair.Key;
                        lastKey = nextKey;
                        hexCode = pair.Value;
                    }
                    else
                    {
                        lastKey = nextKey;
                    }
                }
                else
                {
                    if (firstKey != 0)
                    {
                        if (firstKey == 1) // If the first pixel is required, make it 0.
                        {
                            output += $"{firstKey - 1},{lastKey + 1},\"{hexCode}\"";
                        } else // We will add one to lastKey since WLED is based on "up-to pixel"
                        {
                            if (lastKey == (_imageBitmap.Width * _imageBitmap.Height) - 1)
                            {
                                output += $"{firstKey},{lastKey + 1},\"{hexCode}\"";
                            } else
                            {
                                output += $"{firstKey},{lastKey + 1},\"{hexCode}\"";
                            }
                            
                        }
                        
                        if (pair.Key != pixelDict.Keys.Last())
                        {
                            output += ",";
                        }
                        firstKey = 0;
                        lastKey = 0;
                        hexCode = "";
                    }
                    else
                    { // This covers when there are no consecutives and just a single pixel to set.
                        output += $"{pair.Key},\"{pair.Value}\"";
                        if (pair.Key != pixelDict.Keys.Last())
                        {
                            output += ",";
                        }
                    }
                }
            }
            // Get the last one in the loop if not part of a 'group' of consecutives.
            if (firstKey != 0)
            {
                if (lastKey == (_imageBitmap.Width * _imageBitmap.Height) - 1)
                {
                    output += $"{firstKey - 1},{lastKey + 1},\"{hexCode}\"";
                } else
                {
                    output += $"{firstKey - 1},{lastKey},\"{hexCode}\"";
                }
            }

            output += "]}}";
            resultTextBox.Text = output;

            if (_hassTab && !_pythonGen)
                SendToHassTab();
        }

        private void SendToPythonGenerator()
        {
            ShowPythonListTab(true);
            string variableName = Regex.Replace(_uploadedImageName, "\\.\\w{3,}$", "");
            pythonOutputText.Text += $"{variableName} = {resultTextBox.Text.Replace("\"on\":true", "\"on\":True")}{Environment.NewLine}";
            pythonArtDict.Text = PythonUtil.GetPythonDictionary(pythonOutputText.Text);
            pythonArtList.Text = PythonUtil.GetPythonArtList(pythonArtDict.Text);
            pythonTabBulkBtn.Text = "Select Files...";
            
        }

        private void SendToHassTab()
        {
            if (!_hassTab)
            { return; }

            if (_bulkHass)
            {
                hassOutputText.Text += HassUtil.GetHassSwitch(resultTextBox.Text, Regex.Replace(_uploadedImageName, "\\.\\w{3,}$", ""), true);
            } else
            {
                hassOutputText.Text += HassUtil.GetHassSwitch(resultTextBox.Text, Regex.Replace(_uploadedImageName, "\\.\\w{3,}$", ""), false);
            }
            yamlStartCheckbox.Enabled = true;
            pythonProgressBar.PerformStep();
            pythonTabBulkBtn.Text = "Select Files...";
        }

        public void SetPresetSaved(bool saved)
        {
            _presetSaved = saved;

            savePresetBtn.Enabled = !_presetSaved;
        }

        public void SetUrl(string url)
        {
            _wledUrl = url;
        }

        private void ShowPythonTab(bool visible)
        {
            if (visible)
            {
                if (!tabControl1.TabPages.ContainsKey("pythonTab"))
                    tabControl1.TabPages.Add(pythonTab);
            }
            else
            {
                tabControl1.TabPages.Remove(pythonTab);
            }
            pythonTab.Visible = visible;
        }

        private void ShowPythonListTab(bool visible)
        {
            if (visible)
            {
                if (!tabControl1.TabPages.ContainsKey("pythonListTab"))
                {
                    tabControl1.TabPages.Add(pythonListTab);
                    if (_hassTab)
                    {
                        tabControl1.TabPages.Remove(hassTab);
                        tabControl1.TabPages.Add(hassTab);
                    }
                }
            }
            else
            {
                tabControl1.TabPages.Remove(pythonListTab);
            }
            pythonListTab.Visible = visible;
        }

        private void ShowHassTab(bool visible)
        {
            if (visible)
            {
                hassBulkCheckbox.Visible = true;
                if (!tabControl1.TabPages.ContainsKey("hassTab"))
                    tabControl1.TabPages.Add(hassTab);
            }
            else
            {
                hassBulkCheckbox.Visible = false;
                tabControl1.TabPages.Remove(hassTab);
            }
            hassTab.Visible = visible;
        }

        public string Url => _wledUrl;

        #region Reset Region

        private void ResetForBulk()
        {
            _imageBitmap = null;
            _gridPixelList = new List<GridPixel>();
            imageBox.Image = null;
        }

        private void ResetMainForm()
        {
            resultTextBox.Clear();
            generateBtn.Enabled = false;
            _gridPixelList = new List<GridPixel>();
            imageBox.Image = null;
            selectFileBtn.Enabled = true;
            serpCheckBox.Checked = true;
            hexCheckBox.Checked = true;
            onBrightCheckbox.Checked = false;
            _useHex = hexCheckBox.Checked;
            _serpentine = serpCheckBox.Checked;
            _includeOnBright = onBrightCheckbox.Checked;
            brightLabel.Visible = false;
            brightText.Visible = false;
            postBtn.Visible = false;
            wledOffBtn.Visible = false;
            savePresetBtn.Visible = false;
            yamlStartCheckbox.Enabled = false;
            hassOutputText.Clear();
            _pythonGen = false;
            _bulkHass = false;
            hassBulkCheckbox.Checked = false;
            mainTabCopyBtn.Visible = false;
            hassTabCopyBtn.Visible = false;
            HassUtil.Reset();
            SetPresetSaved(false);
            LoadData();
        }

        private void ResetPythonTab()
        {
            pythonOutputText.Clear();
            pythonArtDict.Clear();
            pythonArtList.Clear();
            pythonTabBulkBtn.Enabled = true;
            _pythonGen = false;
            _bulkHass = false;
            hassBulkCheckbox.Checked = false;
            pythonTabCopyBtn.Visible = false;
            HassUtil.Reset();
            ShowPythonListTab(false);
        }

        #endregion

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (_bulkHass && _pythonGen)
            {
                hassOutputText.Clear();
                _bulkHass = false;
                hassBulkCheckbox.Checked = false;
                _pythonGen = false;
            }
            Image image = imageBox.Image;

            Generate();

            // DEBUG Only.
            // foreach (var pixel in _gridPixelList.OrderBy(p => p.id))
            // {
            //    System.Diagnostics.Debug.WriteLine(pixel.id + " : " + pixel.hexCode);
            // }


            generateBtn.Enabled = false;
            postBtn.Visible = true;
            savePresetBtn.Visible = true;
            wledOffBtn.Visible = true;
            if (_hassTab)
            {
                ShowHassTab(_hassTab);
            }
            mainTabCopyBtn.Visible = true;
            hassTabCopyBtn.Visible = true;
        }

        #region Form Element Interactions

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            string picsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = picsDir,
                Title = "Select Image File",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    HandleImageSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to reset this tab? This cannot be undone.", "Reset Tab", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                ResetMainForm();
            }
        }

        private void hexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hexCheckBox.Checked)
            {
                _useHex = true;
            } else
            {
                _useHex = false;
            }
        }

        private void serpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _serpentine = serpCheckBox.Checked;
        }

        private void onBrightCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (onBrightCheckbox.Checked)
            {
                _includeOnBright = true;
                brightLabel.Visible = true;
                brightText.Visible = true;
            } else
            {
                _includeOnBright = false;
                brightLabel.Visible = false;
                brightText.Visible = false;
            }
        }

        private void brightText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(brightText.Text, out int value))
            {
                brightText.Text = "";
                return;
            }
            _brightness = Math.Clamp(int.Parse(brightText.Text), 0, 255).ToString();
            brightText.Text = _brightness;
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            WledJsonApiClient wled = new WledJsonApiClient(_wledUrl);
            wled.postToWled(resultTextBox.Text);
        }

        private void wledOffBtn_Click(object sender, EventArgs e)
        {
            WledJsonApiClient wled = new WledJsonApiClient(_wledUrl);
            wled.wledOff();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        private void savePresetBtn_Click(object sender, EventArgs e)
        {
            SavePresetForm savePresetForm = new SavePresetForm();
            savePresetForm.PresetJson = resultTextBox.Text;
            savePresetForm.Show();
        }

        private void enablePythonModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pythonTab = enablePythonModeToolStripMenuItem.Checked;
            _data.UsePython = _pythonTab;
            AppDataUtil.SaveData(_data);
            ShowPythonTab(_pythonTab);
        }

        private void enableHomeAssistantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _hassTab = enableHomeAssistantToolStripMenuItem.Checked;
            _data.UseHass = _hassTab;
            AppDataUtil.SaveData(_data);

        }

        private void pythonTabBulkBtn_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length > 0)
            {
                var bulkHassCbState = hassBulkCheckbox.Checked;
                var msg = MessageBox.Show("There is data on the main tab. If you continue, all data will be lost. Do you want to continue? This cannot be undone.", "Overwrite", MessageBoxButtons.YesNo);

                if (msg == DialogResult.No)
                {
                    return;
                }
                ResetMainForm();
                _bulkHass = bulkHassCbState;
                hassBulkCheckbox.Checked = bulkHassCbState;
            }

            string picsDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            pythonOpenFilesDialog = new OpenFileDialog()
            {
                InitialDirectory = picsDir,
                Title = "Select Image File",
                Multiselect = true,

                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (pythonOpenFilesDialog.ShowDialog() == DialogResult.OK)
            {
                pythonTabCopyBtn.Visible = true;
                _pythonGen = true;
                pythonProgressBar.Visible = true;
                pythonProgressBar.Minimum = 1;
                pythonProgressBar.Maximum = pythonOpenFilesDialog.FileNames.Length;
                pythonProgressBar.Value = 1;
                pythonProgressBar.Step = 1;
                pythonTabBulkBtn.Text = "Loading...";
                pythonTabBulkBtn.Enabled = false;
                try
                {
                    for (int i = 0; i < pythonOpenFilesDialog.FileNames.Length; i++)
                    {
                        AddBulkImages(pythonOpenFilesDialog.FileNames[i]);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                } 
                finally
                {
                    pythonProgressBar.Visible = false;
                    if (_bulkHass)
                    {
                        hassTabCopyBtn.Visible = true;
                        ShowHassTab(_hassTab);
                        tabControl1.SelectTab(hassTab);
                    }
                    resultTextBox.Clear();
                }
            }
        }

        private void pythonTabResetBtn_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to reset this tab? This cannot be undone.", "Reset Tab", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                ResetPythonTab();
            }
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to reset ALL tabs? This cannot be undone.", "Reset All", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                ResetPythonTab();
                ResetMainForm();
                tabControl1.SelectTab(tabPage1);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to exit? Any unsaved settings/presets and values will be lost.", "Confirm Exit", MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yamlStartCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            hassOutputText.Text = HassUtil.ToggleYamlStarter(yamlStartCheckbox.Checked);
        }

        private void hassBulkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _bulkHass = hassBulkCheckbox.Checked;
        }

        private void mainTabCopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultTextBox.Text);
        }

        private void pythonTabCopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pythonOutputText.Text);
        }

        private void pythonListCopyDictBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pythonArtDict.Text);
        }

        private void pythonListCopyListBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pythonArtList.Text);
        }

        private void hassTabCopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hassOutputText.Text);
        }

        #endregion
    }
}

public class GridPixel
{
    public int id;
    public string hexCode;
}