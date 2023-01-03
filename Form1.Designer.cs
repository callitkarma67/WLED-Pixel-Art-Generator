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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enablePythonModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableHomeAssistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.pythonTabResetBtn = new System.Windows.Forms.Button();
            this.pythonTabBulkBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pythonOutputText = new System.Windows.Forms.TextBox();
            this.pythonOpenFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.pythonTab.SuspendLayout();
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
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1714, 45);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(262, 48);
            this.preferencesToolStripMenuItem.Text = "Settings";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 48);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enablePythonModeToolStripMenuItem,
            this.enableHomeAssistantToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(133, 41);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // enablePythonModeToolStripMenuItem
            // 
            this.enablePythonModeToolStripMenuItem.CheckOnClick = true;
            this.enablePythonModeToolStripMenuItem.Name = "enablePythonModeToolStripMenuItem";
            this.enablePythonModeToolStripMenuItem.Size = new System.Drawing.Size(437, 48);
            this.enablePythonModeToolStripMenuItem.Text = "Enable Python Mode";
            this.enablePythonModeToolStripMenuItem.Click += new System.EventHandler(this.enablePythonModeToolStripMenuItem_Click);
            // 
            // enableHomeAssistantToolStripMenuItem
            // 
            this.enableHomeAssistantToolStripMenuItem.CheckOnClick = true;
            this.enableHomeAssistantToolStripMenuItem.Enabled = false;
            this.enableHomeAssistantToolStripMenuItem.Name = "enableHomeAssistantToolStripMenuItem";
            this.enableHomeAssistantToolStripMenuItem.Size = new System.Drawing.Size(437, 48);
            this.enableHomeAssistantToolStripMenuItem.Text = "Enable Home Assistant";
            this.enableHomeAssistantToolStripMenuItem.Visible = false;
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(437, 48);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.pythonTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1702, 1189);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(10, 55);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1682, 1124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wledOffBtn
            // 
            this.wledOffBtn.Location = new System.Drawing.Point(650, 1042);
            this.wledOffBtn.Name = "wledOffBtn";
            this.wledOffBtn.Size = new System.Drawing.Size(169, 52);
            this.wledOffBtn.TabIndex = 27;
            this.wledOffBtn.Text = "WLED Off";
            this.wledOffBtn.UseVisualStyleBackColor = true;
            this.wledOffBtn.Visible = false;
            this.wledOffBtn.Click += new System.EventHandler(this.wledOffBtn_Click);
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(868, 1042);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(197, 52);
            this.postBtn.TabIndex = 26;
            this.postBtn.Text = "Post to WLED";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Visible = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // brightText
            // 
            this.brightText.Location = new System.Drawing.Point(1291, 218);
            this.brightText.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.brightText.MaxLength = 3;
            this.brightText.Name = "brightText";
            this.brightText.Size = new System.Drawing.Size(139, 43);
            this.brightText.TabIndex = 25;
            this.brightText.Visible = false;
            this.brightText.TextChanged += new System.EventHandler(this.brightText_TextChanged);
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(1105, 218);
            this.brightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(139, 37);
            this.brightLabel.TabIndex = 24;
            this.brightLabel.Text = "Brightness";
            this.brightLabel.Visible = false;
            // 
            // onBrightCheckbox
            // 
            this.onBrightCheckbox.AutoSize = true;
            this.onBrightCheckbox.Location = new System.Drawing.Point(1105, 146);
            this.onBrightCheckbox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.onBrightCheckbox.Name = "onBrightCheckbox";
            this.onBrightCheckbox.Size = new System.Drawing.Size(333, 41);
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
            this.hexCheckBox.Location = new System.Drawing.Point(811, 208);
            this.hexCheckBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(226, 41);
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
            this.serpCheckBox.Location = new System.Drawing.Point(811, 146);
            this.serpCheckBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.serpCheckBox.Name = "serpCheckBox";
            this.serpCheckBox.Size = new System.Drawing.Size(176, 41);
            this.serpCheckBox.TabIndex = 21;
            this.serpCheckBox.Text = "Serpentine";
            this.serpCheckBox.UseVisualStyleBackColor = true;
            this.serpCheckBox.CheckedChanged += new System.EventHandler(this.serpCheckBox_CheckedChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(10, 1037);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(161, 57);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // savePresetBtn
            // 
            this.savePresetBtn.Location = new System.Drawing.Point(1467, 1037);
            this.savePresetBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.savePresetBtn.Name = "savePresetBtn";
            this.savePresetBtn.Size = new System.Drawing.Size(206, 57);
            this.savePresetBtn.TabIndex = 19;
            this.savePresetBtn.Text = "Save as Preset";
            this.savePresetBtn.UseVisualStyleBackColor = true;
            this.savePresetBtn.Visible = false;
            this.savePresetBtn.Click += new System.EventHandler(this.savePresetBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(809, 33);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(161, 57);
            this.generateBtn.TabIndex = 18;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(650, 30);
            this.imageBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(34, 39);
            this.imageBox.TabIndex = 17;
            this.imageBox.TabStop = false;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(312, 33);
            this.selectFileBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(197, 57);
            this.selectFileBtn.TabIndex = 16;
            this.selectFileBtn.Text = "Select File...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input Image (16x16px)";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(10, 507);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(1658, 485);
            this.resultTextBox.TabIndex = 14;
            // 
            // pythonTab
            // 
            this.pythonTab.Controls.Add(this.label3);
            this.pythonTab.Controls.Add(this.pythonTabResetBtn);
            this.pythonTab.Controls.Add(this.pythonTabBulkBtn);
            this.pythonTab.Controls.Add(this.label2);
            this.pythonTab.Controls.Add(this.pythonOutputText);
            this.pythonTab.Location = new System.Drawing.Point(10, 55);
            this.pythonTab.Name = "pythonTab";
            this.pythonTab.Padding = new System.Windows.Forms.Padding(3);
            this.pythonTab.Size = new System.Drawing.Size(1682, 1124);
            this.pythonTab.TabIndex = 1;
            this.pythonTab.Text = "Python Gen";
            this.pythonTab.UseVisualStyleBackColor = true;
            // 
            // pythonTabResetBtn
            // 
            this.pythonTabResetBtn.Location = new System.Drawing.Point(1508, 31);
            this.pythonTabResetBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pythonTabResetBtn.Name = "pythonTabResetBtn";
            this.pythonTabResetBtn.Size = new System.Drawing.Size(161, 57);
            this.pythonTabResetBtn.TabIndex = 21;
            this.pythonTabResetBtn.Text = "Reset Tab";
            this.pythonTabResetBtn.UseVisualStyleBackColor = true;
            this.pythonTabResetBtn.Click += new System.EventHandler(this.pythonTabResetBtn_Click);
            // 
            // pythonTabBulkBtn
            // 
            this.pythonTabBulkBtn.Location = new System.Drawing.Point(321, 31);
            this.pythonTabBulkBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pythonTabBulkBtn.Name = "pythonTabBulkBtn";
            this.pythonTabBulkBtn.Size = new System.Drawing.Size(197, 57);
            this.pythonTabBulkBtn.TabIndex = 20;
            this.pythonTabBulkBtn.Text = "Select Files...";
            this.pythonTabBulkBtn.UseVisualStyleBackColor = true;
            this.pythonTabBulkBtn.Click += new System.EventHandler(this.pythonTabBulkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bulk Image Import";
            // 
            // pythonOutputText
            // 
            this.pythonOutputText.Location = new System.Drawing.Point(15, 117);
            this.pythonOutputText.Multiline = true;
            this.pythonOutputText.Name = "pythonOutputText";
            this.pythonOutputText.Size = new System.Drawing.Size(1654, 982);
            this.pythonOutputText.TabIndex = 0;
            // 
            // pythonOpenFilesDialog
            // 
            this.pythonOpenFilesDialog.Multiselect = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(899, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "This creates python variables based on filename, so name files accordingly.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1236);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
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
    }
}