namespace WLED_Pixel_Art_Generator
{
    public partial class Form1 : Form
    {
        private Bitmap _imageBitmap;
        private List<GridPixel> _gridPixelList = new List<GridPixel>();
        private bool _useHex;
        private bool _serpentine;
        private bool _includeOnBright;
        private string _brightness;
        public Form1()
        {
            InitializeComponent();
            generateBtn.Enabled = false;
            _useHex = hexCheckBox.Checked;
            _serpentine = serpCheckBox.Checked;
            brightText.Text = "25";
            _brightness = brightText.Text;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Select Image File",

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
                    imageBox.Height = 16;
                    imageBox.Width = 16;

                    Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);

                    Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                    _imageBitmap = bitmap;

                    if (!validImage(_imageBitmap))
                    {
                        MessageBox.Show("Sorry, only images that are 16 x 16px are supported at this time.");
                        return;
                    }
                    Image uploadedImage = bitmap.GetThumbnailImage(16, 16, myCallback, IntPtr.Zero);

                    imageBox.Image = uploadedImage;
                    generateBtn.Enabled = true;
                    selectFileBtn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private bool validImage(Bitmap bitmap)
        {
            return _imageBitmap.Width == 16 && _imageBitmap.Height == 16;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Image image = imageBox.Image;

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
            } else
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
                    } else
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
            
            // DEBUG Only.
            //foreach (var pixel in _gridPixelList.OrderBy(p => p.id))
            //{
            //    System.Diagnostics.Debug.WriteLine(pixel.id + " : " + pixel.hexCode);
            //}

            ConsolidateAndOutput();
            generateBtn.Enabled = false;
        }

        private string ConvertToHex(Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void SetupMatrix(int current, Color pixel)
        {
            GridPixel gridPixel = new GridPixel();
            
            gridPixel.id = current;
            gridPixel.hexCode = ConvertToHex(pixel);

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
            string output = "{\"seg\":{\"id\":0,\"i\":[";

            if (_includeOnBright)
            {
                output = $"{{\"on\":true,\"bri\":{_brightness},\"seg\":{{\"id\":0,\"i\":[";
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
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            generateBtn.Enabled = false;
            _imageBitmap = null;
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
            if (serpCheckBox.Checked)
            {
                _serpentine = true;
            } else
            {
                _serpentine= false;
            }
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
                _includeOnBright= false;
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
            _brightness = brightText.Text;
        }
    }
}

public class GridPixel
{
    public int id;
    public string hexCode;
}