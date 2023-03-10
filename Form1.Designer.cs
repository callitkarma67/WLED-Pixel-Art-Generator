namespace WLED_Pixel_Art_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enablePythonModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableHomeAssistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainTabCopyBtn = new System.Windows.Forms.Button();
            this.wledOffBtn = new System.Windows.Forms.Button();
            this.postBtn = new System.Windows.Forms.Button();
            this.brightText = new System.Windows.Forms.TextBox();
            this.brightLabel = new System.Windows.Forms.Label();
            this.onBrightCheckbox = new System.Windows.Forms.CheckBox();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.serpCheckBox = new System.Windows.Forms.CheckBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.savePresetBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.pythonTab = new System.Windows.Forms.TabPage();
            this.pythonTabCopyBtn = new System.Windows.Forms.Button();
            this.hassBulkCheckbox = new System.Windows.Forms.CheckBox();
            this.pythonProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pythonTabResetBtn = new System.Windows.Forms.Button();
            this.pythonTabBulkBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pythonOutputText = new System.Windows.Forms.TextBox();
            this.pythonListTab = new System.Windows.Forms.TabPage();
            this.pythonListCopyListBtn = new System.Windows.Forms.Button();
            this.pythonListCopyDictBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pythonArtList = new System.Windows.Forms.TextBox();
            this.pythonArtDict = new System.Windows.Forms.TextBox();
            this.hassTab = new System.Windows.Forms.TabPage();
            this.hassTabCopyBtn = new System.Windows.Forms.Button();
            this.yamlStartCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hassOutputText = new System.Windows.Forms.TextBox();
            this.pythonOpenFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.pythonTab.SuspendLayout();
            this.pythonListTab.SuspendLayout();
            this.hassTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.preferencesToolStripMenuItem.Text = "Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enablePythonModeToolStripMenuItem,
            this.enableHomeAssistantToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // enablePythonModeToolStripMenuItem
            // 
            this.enablePythonModeToolStripMenuItem.CheckOnClick = true;
            this.enablePythonModeToolStripMenuItem.Name = "enablePythonModeToolStripMenuItem";
            this.enablePythonModeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.enablePythonModeToolStripMenuItem.Text = "Enable Python Mode";
            this.enablePythonModeToolStripMenuItem.Click += new System.EventHandler(this.enablePythonModeToolStripMenuItem_Click);
            // 
            // enableHomeAssistantToolStripMenuItem
            // 
            this.enableHomeAssistantToolStripMenuItem.CheckOnClick = true;
            this.enableHomeAssistantToolStripMenuItem.Name = "enableHomeAssistantToolStripMenuItem";
            this.enableHomeAssistantToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.enableHomeAssistantToolStripMenuItem.Text = "Enable Home Assistant";
            this.enableHomeAssistantToolStripMenuItem.Click += new System.EventHandler(this.enableHomeAssistantToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.pythonTab);
            this.tabControl1.Controls.Add(this.pythonListTab);
            this.tabControl1.Controls.Add(this.hassTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 527);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainTabCopyBtn);
            this.tabPage1.Controls.Add(this.wledOffBtn);
            this.tabPage1.Controls.Add(this.postBtn);
            this.tabPage1.Controls.Add(this.brightText);
            this.tabPage1.Controls.Add(this.brightLabel);
            this.tabPage1.Controls.Add(this.onBrightCheckbox);
            this.tabPage1.Controls.Add(this.hexCheckBox);
            this.tabPage1.Controls.Add(this.serpCheckBox);
            this.tabPage1.Controls.Add(this.resetBtn);
            this.tabPage1.Controls.Add(this.savePresetBtn);
            this.tabPage1.Controls.Add(this.generateBtn);
            this.tabPage1.Controls.Add(this.imageBox);
            this.tabPage1.Controls.Add(this.selectFileBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.resultTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(792, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainTabCopyBtn
            // 
            this.mainTabCopyBtn.Location = new System.Drawing.Point(706, 177);
            this.mainTabCopyBtn.Name = "mainTabCopyBtn";
            this.mainTabCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.mainTabCopyBtn.TabIndex = 28;
            this.mainTabCopyBtn.Text = "Copy";
            this.mainTabCopyBtn.UseVisualStyleBackColor = true;
            this.mainTabCopyBtn.Visible = false;
            this.mainTabCopyBtn.Click += new System.EventHandler(this.mainTabCopyBtn_Click);
            // 
            // wledOffBtn
            // 
            this.wledOffBtn.Location = new System.Drawing.Point(303, 422);
            this.wledOffBtn.Margin = new System.Windows.Forms.Padding(1);
            this.wledOffBtn.Name = "wledOffBtn";
            this.wledOffBtn.Size = new System.Drawing.Size(79, 21);
            this.wledOffBtn.TabIndex = 27;
            this.wledOffBtn.Text = "WLED Off";
            this.wledOffBtn.UseVisualStyleBackColor = true;
            this.wledOffBtn.Visible = false;
            this.wledOffBtn.Click += new System.EventHandler(this.wledOffBtn_Click);
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(405, 422);
            this.postBtn.Margin = new System.Windows.Forms.Padding(1);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(92, 21);
            this.postBtn.TabIndex = 26;
            this.postBtn.Text = "Post to WLED";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Visible = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // brightText
            // 
            this.brightText.Location = new System.Drawing.Point(602, 88);
            this.brightText.MaxLength = 3;
            this.brightText.Name = "brightText";
            this.brightText.Size = new System.Drawing.Size(67, 23);
            this.brightText.TabIndex = 25;
            this.brightText.Visible = false;
            this.brightText.TextChanged += new System.EventHandler(this.brightText_TextChanged);
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(516, 88);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(62, 15);
            this.brightLabel.TabIndex = 24;
            this.brightLabel.Text = "Brightness";
            this.brightLabel.Visible = false;
            // 
            // onBrightCheckbox
            // 
            this.onBrightCheckbox.AutoSize = true;
            this.onBrightCheckbox.Location = new System.Drawing.Point(516, 59);
            this.onBrightCheckbox.Name = "onBrightCheckbox";
            this.onBrightCheckbox.Size = new System.Drawing.Size(154, 19);
            this.onBrightCheckbox.TabIndex = 23;
            this.onBrightCheckbox.Text = "Include On/Bri elements";
            this.onBrightCheckbox.UseVisualStyleBackColor = true;
            this.onBrightCheckbox.CheckedChanged += new System.EventHandler(this.onBrightCheckbox_CheckedChanged);
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Checked = true;
            this.hexCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexCheckBox.Location = new System.Drawing.Point(378, 84);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(105, 19);
            this.hexCheckBox.TabIndex = 22;
            this.hexCheckBox.Text = "Use Hex Codes";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            this.hexCheckBox.CheckedChanged += new System.EventHandler(this.hexCheckBox_CheckedChanged);
            // 
            // serpCheckBox
            // 
            this.serpCheckBox.AutoSize = true;
            this.serpCheckBox.Checked = true;
            this.serpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serpCheckBox.Location = new System.Drawing.Point(378, 59);
            this.serpCheckBox.Name = "serpCheckBox";
            this.serpCheckBox.Size = new System.Drawing.Size(82, 19);
            this.serpCheckBox.TabIndex = 21;
            this.serpCheckBox.Text = "Serpentine";
            this.serpCheckBox.UseVisualStyleBackColor = true;
            this.serpCheckBox.CheckedChanged += new System.EventHandler(this.serpCheckBox_CheckedChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(5, 420);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // savePresetBtn
            // 
            this.savePresetBtn.Location = new System.Drawing.Point(685, 420);
            this.savePresetBtn.Name = "savePresetBtn";
            this.savePresetBtn.Size = new System.Drawing.Size(96, 23);
            this.savePresetBtn.TabIndex = 19;
            this.savePresetBtn.Text = "Save as Preset";
            this.savePresetBtn.UseVisualStyleBackColor = true;
            this.savePresetBtn.Visible = false;
            this.savePresetBtn.Click += new System.EventHandler(this.savePresetBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(378, 13);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 18;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(303, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(16, 16);
            this.imageBox.TabIndex = 17;
            this.imageBox.TabStop = false;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(146, 13);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(92, 23);
            this.selectFileBtn.TabIndex = 16;
            this.selectFileBtn.Text = "Select File...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input Image (16x16px)";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(5, 206);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(776, 199);
            this.resultTextBox.TabIndex = 14;
            // 
            // pythonTab
            // 
            this.pythonTab.Controls.Add(this.pythonTabCopyBtn);
            this.pythonTab.Controls.Add(this.hassBulkCheckbox);
            this.pythonTab.Controls.Add(this.pythonProgressBar);
            this.pythonTab.Controls.Add(this.label3);
            this.pythonTab.Controls.Add(this.pythonTabResetBtn);
            this.pythonTab.Controls.Add(this.pythonTabBulkBtn);
            this.pythonTab.Controls.Add(this.label2);
            this.pythonTab.Controls.Add(this.pythonOutputText);
            this.pythonTab.Location = new System.Drawing.Point(4, 24);
            this.pythonTab.Margin = new System.Windows.Forms.Padding(1);
            this.pythonTab.Name = "pythonTab";
            this.pythonTab.Padding = new System.Windows.Forms.Padding(1);
            this.pythonTab.Size = new System.Drawing.Size(792, 499);
            this.pythonTab.TabIndex = 1;
            this.pythonTab.Text = "Python/Bulk Gen";
            this.pythonTab.UseVisualStyleBackColor = true;
            // 
            // pythonTabCopyBtn
            // 
            this.pythonTabCopyBtn.Location = new System.Drawing.Point(704, 61);
            this.pythonTabCopyBtn.Name = "pythonTabCopyBtn";
            this.pythonTabCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.pythonTabCopyBtn.TabIndex = 31;
            this.pythonTabCopyBtn.Text = "Copy";
            this.pythonTabCopyBtn.UseVisualStyleBackColor = true;
            this.pythonTabCopyBtn.Visible = false;
            this.pythonTabCopyBtn.Click += new System.EventHandler(this.pythonTabCopyBtn_Click);
            // 
            // hassBulkCheckbox
            // 
            this.hassBulkCheckbox.AutoSize = true;
            this.hassBulkCheckbox.Location = new System.Drawing.Point(19, 41);
            this.hassBulkCheckbox.Name = "hassBulkCheckbox";
            this.hassBulkCheckbox.Size = new System.Drawing.Size(226, 19);
            this.hassBulkCheckbox.TabIndex = 30;
            this.hassBulkCheckbox.Text = "Generate for Home Assistant Switches";
            this.hassBulkCheckbox.UseVisualStyleBackColor = true;
            this.hassBulkCheckbox.CheckedChanged += new System.EventHandler(this.hassBulkCheckbox_CheckedChanged);
            // 
            // pythonProgressBar
            // 
            this.pythonProgressBar.Location = new System.Drawing.Point(7, 469);
            this.pythonProgressBar.Name = "pythonProgressBar";
            this.pythonProgressBar.Size = new System.Drawing.Size(774, 23);
            this.pythonProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pythonProgressBar.TabIndex = 29;
            this.pythonProgressBar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "This creates python variables based on filename, so name files accordingly.";
            // 
            // pythonTabResetBtn
            // 
            this.pythonTabResetBtn.Location = new System.Drawing.Point(704, 13);
            this.pythonTabResetBtn.Name = "pythonTabResetBtn";
            this.pythonTabResetBtn.Size = new System.Drawing.Size(75, 23);
            this.pythonTabResetBtn.TabIndex = 21;
            this.pythonTabResetBtn.Text = "Reset Tab";
            this.pythonTabResetBtn.UseVisualStyleBackColor = true;
            this.pythonTabResetBtn.Click += new System.EventHandler(this.pythonTabResetBtn_Click);
            // 
            // pythonTabBulkBtn
            // 
            this.pythonTabBulkBtn.Location = new System.Drawing.Point(150, 13);
            this.pythonTabBulkBtn.Name = "pythonTabBulkBtn";
            this.pythonTabBulkBtn.Size = new System.Drawing.Size(92, 23);
            this.pythonTabBulkBtn.TabIndex = 20;
            this.pythonTabBulkBtn.Text = "Select Files...";
            this.pythonTabBulkBtn.UseVisualStyleBackColor = true;
            this.pythonTabBulkBtn.Click += new System.EventHandler(this.pythonTabBulkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bulk Image Import";
            // 
            // pythonOutputText
            // 
            this.pythonOutputText.Location = new System.Drawing.Point(7, 88);
            this.pythonOutputText.Margin = new System.Windows.Forms.Padding(1);
            this.pythonOutputText.Multiline = true;
            this.pythonOutputText.Name = "pythonOutputText";
            this.pythonOutputText.ReadOnly = true;
            this.pythonOutputText.Size = new System.Drawing.Size(774, 377);
            this.pythonOutputText.TabIndex = 0;
            // 
            // pythonListTab
            // 
            this.pythonListTab.Controls.Add(this.pythonListCopyListBtn);
            this.pythonListTab.Controls.Add(this.pythonListCopyDictBtn);
            this.pythonListTab.Controls.Add(this.label5);
            this.pythonListTab.Controls.Add(this.label4);
            this.pythonListTab.Controls.Add(this.pythonArtList);
            this.pythonListTab.Controls.Add(this.pythonArtDict);
            this.pythonListTab.Location = new System.Drawing.Point(4, 24);
            this.pythonListTab.Name = "pythonListTab";
            this.pythonListTab.Size = new System.Drawing.Size(792, 499);
            this.pythonListTab.TabIndex = 2;
            this.pythonListTab.Text = "Python List";
            this.pythonListTab.UseVisualStyleBackColor = true;
            // 
            // pythonListCopyListBtn
            // 
            this.pythonListCopyListBtn.Location = new System.Drawing.Point(697, 10);
            this.pythonListCopyListBtn.Name = "pythonListCopyListBtn";
            this.pythonListCopyListBtn.Size = new System.Drawing.Size(75, 23);
            this.pythonListCopyListBtn.TabIndex = 6;
            this.pythonListCopyListBtn.Text = "Copy";
            this.pythonListCopyListBtn.UseVisualStyleBackColor = true;
            this.pythonListCopyListBtn.Click += new System.EventHandler(this.pythonListCopyListBtn_Click);
            // 
            // pythonListCopyDictBtn
            // 
            this.pythonListCopyDictBtn.Location = new System.Drawing.Point(234, 10);
            this.pythonListCopyDictBtn.Name = "pythonListCopyDictBtn";
            this.pythonListCopyDictBtn.Size = new System.Drawing.Size(75, 23);
            this.pythonListCopyDictBtn.TabIndex = 5;
            this.pythonListCopyDictBtn.Text = "Copy";
            this.pythonListCopyDictBtn.UseVisualStyleBackColor = true;
            this.pythonListCopyDictBtn.Click += new System.EventHandler(this.pythonListCopyDictBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Art List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dictionary Mapping";
            // 
            // pythonArtList
            // 
            this.pythonArtList.Location = new System.Drawing.Point(469, 41);
            this.pythonArtList.Margin = new System.Windows.Forms.Padding(1);
            this.pythonArtList.Multiline = true;
            this.pythonArtList.Name = "pythonArtList";
            this.pythonArtList.ReadOnly = true;
            this.pythonArtList.Size = new System.Drawing.Size(303, 453);
            this.pythonArtList.TabIndex = 2;
            // 
            // pythonArtDict
            // 
            this.pythonArtDict.Location = new System.Drawing.Point(6, 41);
            this.pythonArtDict.Margin = new System.Windows.Forms.Padding(1);
            this.pythonArtDict.Multiline = true;
            this.pythonArtDict.Name = "pythonArtDict";
            this.pythonArtDict.ReadOnly = true;
            this.pythonArtDict.Size = new System.Drawing.Size(303, 453);
            this.pythonArtDict.TabIndex = 1;
            // 
            // hassTab
            // 
            this.hassTab.Controls.Add(this.hassTabCopyBtn);
            this.hassTab.Controls.Add(this.yamlStartCheckbox);
            this.hassTab.Controls.Add(this.label6);
            this.hassTab.Controls.Add(this.hassOutputText);
            this.hassTab.Location = new System.Drawing.Point(4, 24);
            this.hassTab.Name = "hassTab";
            this.hassTab.Size = new System.Drawing.Size(792, 499);
            this.hassTab.TabIndex = 3;
            this.hassTab.Text = "Home Assistant";
            this.hassTab.UseVisualStyleBackColor = true;
            // 
            // hassTabCopyBtn
            // 
            this.hassTabCopyBtn.Location = new System.Drawing.Point(708, 19);
            this.hassTabCopyBtn.Name = "hassTabCopyBtn";
            this.hassTabCopyBtn.Size = new System.Drawing.Size(75, 23);
            this.hassTabCopyBtn.TabIndex = 6;
            this.hassTabCopyBtn.Text = "Copy";
            this.hassTabCopyBtn.UseVisualStyleBackColor = true;
            this.hassTabCopyBtn.Visible = false;
            this.hassTabCopyBtn.Click += new System.EventHandler(this.hassTabCopyBtn_Click);
            // 
            // yamlStartCheckbox
            // 
            this.yamlStartCheckbox.AutoSize = true;
            this.yamlStartCheckbox.Checked = true;
            this.yamlStartCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yamlStartCheckbox.Enabled = false;
            this.yamlStartCheckbox.Location = new System.Drawing.Point(9, 15);
            this.yamlStartCheckbox.Name = "yamlStartCheckbox";
            this.yamlStartCheckbox.Size = new System.Drawing.Size(157, 19);
            this.yamlStartCheckbox.TabIndex = 3;
            this.yamlStartCheckbox.Text = "Add/Remove YAML Start";
            this.yamlStartCheckbox.UseVisualStyleBackColor = true;
            this.yamlStartCheckbox.CheckedChanged += new System.EventHandler(this.yamlStartCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Output is generated by Main or Python/Bulk Gen Tabs";
            // 
            // hassOutputText
            // 
            this.hassOutputText.Location = new System.Drawing.Point(9, 49);
            this.hassOutputText.Margin = new System.Windows.Forms.Padding(1);
            this.hassOutputText.Multiline = true;
            this.hassOutputText.Name = "hassOutputText";
            this.hassOutputText.ReadOnly = true;
            this.hassOutputText.Size = new System.Drawing.Size(774, 400);
            this.hassOutputText.TabIndex = 1;
            // 
            // pythonOpenFilesDialog
            // 
            this.pythonOpenFilesDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WLED Pixel Art Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.pythonTab.ResumeLayout(false);
            this.pythonTab.PerformLayout();
            this.pythonListTab.ResumeLayout(false);
            this.pythonListTab.PerformLayout();
            this.hassTab.ResumeLayout(false);
            this.hassTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem enablePythonModeToolStripMenuItem;
        private ToolStripMenuItem enableHomeAssistantToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button wledOffBtn;
        private Button postBtn;
        private TextBox brightText;
        private Label brightLabel;
        private CheckBox onBrightCheckbox;
        private CheckBox hexCheckBox;
        private CheckBox serpCheckBox;
        private Button resetBtn;
        private Button savePresetBtn;
        private Button generateBtn;
        private PictureBox imageBox;
        private Button selectFileBtn;
        private Label label1;
        private TextBox resultTextBox;
        private TabPage pythonTab;
        private TextBox pythonOutputText;
        private Button pythonTabResetBtn;
        private Button pythonTabBulkBtn;
        private Label label2;
        private OpenFileDialog pythonOpenFilesDialog;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private Label label3;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage pythonListTab;
        private Label label5;
        private Label label4;
        private TextBox pythonArtList;
        private TextBox pythonArtDict;
        private ProgressBar pythonProgressBar;
        private TabPage hassTab;
        private Label label6;
        private TextBox hassOutputText;
        private CheckBox yamlStartCheckbox;
        private CheckBox hassBulkCheckbox;
        private Button mainTabCopyBtn;
        private Button pythonTabCopyBtn;
        private Button pythonListCopyListBtn;
        private Button pythonListCopyDictBtn;
        private Button hassTabCopyBtn;
    }
}