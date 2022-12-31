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
            this.copyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.serpCheckBox = new System.Windows.Forms.CheckBox();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.onBrightCheckbox = new System.Windows.Forms.CheckBox();
            this.brightLabel = new System.Windows.Forms.Label();
            this.brightText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 239);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(776, 199);
            this.resultTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Image (16x16px)";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(153, 47);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(92, 23);
            this.selectFileBtn.TabIndex = 2;
            this.selectFileBtn.Text = "Select File...";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(311, 46);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(16, 16);
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(385, 47);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(713, 454);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 5;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 454);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
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
            this.serpCheckBox.Location = new System.Drawing.Point(386, 93);
            this.serpCheckBox.Name = "serpCheckBox";
            this.serpCheckBox.Size = new System.Drawing.Size(82, 19);
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
            this.hexCheckBox.Location = new System.Drawing.Point(386, 118);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(105, 19);
            this.hexCheckBox.TabIndex = 8;
            this.hexCheckBox.Text = "Use Hex Codes";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            this.hexCheckBox.CheckedChanged += new System.EventHandler(this.hexCheckBox_CheckedChanged);
            // 
            // onBrightCheckbox
            // 
            this.onBrightCheckbox.AutoSize = true;
            this.onBrightCheckbox.Location = new System.Drawing.Point(523, 93);
            this.onBrightCheckbox.Name = "onBrightCheckbox";
            this.onBrightCheckbox.Size = new System.Drawing.Size(154, 19);
            this.onBrightCheckbox.TabIndex = 9;
            this.onBrightCheckbox.Text = "Include On/Bri elements";
            this.onBrightCheckbox.UseVisualStyleBackColor = true;
            this.onBrightCheckbox.CheckedChanged += new System.EventHandler(this.onBrightCheckbox_CheckedChanged);
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(523, 122);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(62, 15);
            this.brightLabel.TabIndex = 10;
            this.brightLabel.Text = "Brightness";
            this.brightLabel.Visible = false;
            // 
            // brightText
            // 
            this.brightText.Location = new System.Drawing.Point(610, 122);
            this.brightText.MaxLength = 3;
            this.brightText.Name = "brightText";
            this.brightText.Size = new System.Drawing.Size(67, 23);
            this.brightText.TabIndex = 11;
            this.brightText.Visible = false;
            this.brightText.TextChanged += new System.EventHandler(this.brightText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.brightText);
            this.Controls.Add(this.brightLabel);
            this.Controls.Add(this.onBrightCheckbox);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.serpCheckBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "WLED Pixel Art Generator";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
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
        private Button copyBtn;
        private Button resetBtn;
        private CheckBox serpCheckBox;
        private CheckBox hexCheckBox;
        private CheckBox onBrightCheckbox;
        private Label brightLabel;
        private TextBox brightText;
    }
}