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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.savePresetBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.serpCheckBox = new System.Windows.Forms.CheckBox();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.onBrightCheckbox = new System.Windows.Forms.CheckBox();
            this.brightLabel = new System.Windows.Forms.Label();
            this.brightText = new System.Windows.Forms.TextBox();
            this.postBtn = new System.Windows.Forms.Button();
            this.wledOffBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(26, 590);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(1658, 485);
            this.resultTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Image (16x16px)";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(328, 116);
            this.selectFileBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(197, 57);
            this.selectFileBtn.TabIndex = 2;
            this.selectFileBtn.Text = "Select File...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(666, 113);
            this.imageBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(34, 39);
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(825, 116);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(161, 57);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // savePresetBtn
            // 
            this.savePresetBtn.Location = new System.Drawing.Point(1483, 1120);
            this.savePresetBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.savePresetBtn.Name = "savePresetBtn";
            this.savePresetBtn.Size = new System.Drawing.Size(206, 57);
            this.savePresetBtn.TabIndex = 5;
            this.savePresetBtn.Text = "Save as Preset";
            this.savePresetBtn.UseVisualStyleBackColor = true;
            this.savePresetBtn.Click += new System.EventHandler(this.savePresetBtn_Click);
            this.savePresetBtn.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(26, 1120);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(161, 57);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // serpCheckBox
            // 
            this.serpCheckBox.AutoSize = true;
            this.serpCheckBox.Checked = true;
            this.serpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serpCheckBox.Location = new System.Drawing.Point(827, 229);
            this.serpCheckBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.serpCheckBox.Name = "serpCheckBox";
            this.serpCheckBox.Size = new System.Drawing.Size(176, 41);
            this.serpCheckBox.TabIndex = 7;
            this.serpCheckBox.Text = "Serpentine";
            this.serpCheckBox.UseVisualStyleBackColor = true;
            this.serpCheckBox.CheckedChanged += new System.EventHandler(this.serpCheckBox_CheckedChanged);
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Checked = true;
            this.hexCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexCheckBox.Location = new System.Drawing.Point(827, 291);
            this.hexCheckBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(226, 41);
            this.hexCheckBox.TabIndex = 8;
            this.hexCheckBox.Text = "Use Hex Codes";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            this.hexCheckBox.CheckedChanged += new System.EventHandler(this.hexCheckBox_CheckedChanged);
            // 
            // onBrightCheckbox
            // 
            this.onBrightCheckbox.AutoSize = true;
            this.onBrightCheckbox.Location = new System.Drawing.Point(1121, 229);
            this.onBrightCheckbox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.onBrightCheckbox.Name = "onBrightCheckbox";
            this.onBrightCheckbox.Size = new System.Drawing.Size(333, 41);
            this.onBrightCheckbox.TabIndex = 9;
            this.onBrightCheckbox.Text = "Include On/Bri elements";
            this.onBrightCheckbox.UseVisualStyleBackColor = true;
            this.onBrightCheckbox.CheckedChanged += new System.EventHandler(this.onBrightCheckbox_CheckedChanged);
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(1121, 301);
            this.brightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(139, 37);
            this.brightLabel.TabIndex = 10;
            this.brightLabel.Text = "Brightness";
            this.brightLabel.Visible = false;
            // 
            // brightText
            // 
            this.brightText.Location = new System.Drawing.Point(1307, 301);
            this.brightText.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.brightText.MaxLength = 3;
            this.brightText.Name = "brightText";
            this.brightText.Size = new System.Drawing.Size(139, 43);
            this.brightText.TabIndex = 11;
            this.brightText.Visible = false;
            this.brightText.TextChanged += new System.EventHandler(this.brightText_TextChanged);
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(884, 1125);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(197, 52);
            this.postBtn.TabIndex = 12;
            this.postBtn.Text = "Post to WLED";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Visible = false;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // wledOffBtn
            // 
            this.wledOffBtn.Location = new System.Drawing.Point(666, 1125);
            this.wledOffBtn.Name = "wledOffBtn";
            this.wledOffBtn.Size = new System.Drawing.Size(169, 52);
            this.wledOffBtn.TabIndex = 13;
            this.wledOffBtn.Text = "WLED Off";
            this.wledOffBtn.UseVisualStyleBackColor = true;
            this.wledOffBtn.Visible = false;
            this.wledOffBtn.Click += new System.EventHandler(this.wledOffBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1236);
            this.Controls.Add(this.wledOffBtn);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.brightText);
            this.Controls.Add(this.brightLabel);
            this.Controls.Add(this.onBrightCheckbox);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.serpCheckBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.savePresetBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "WLED Pixel Art Generator";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox resultTextBox;
        private Label label1;
        private Button selectFileBtn;
        private PictureBox imageBox;
        private Button generateBtn;
        private Button savePresetBtn;
        private Button resetBtn;
        private CheckBox serpCheckBox;
        private CheckBox hexCheckBox;
        private CheckBox onBrightCheckbox;
        private Label brightLabel;
        private TextBox brightText;
        private Button postBtn;
        private Button wledOffBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}