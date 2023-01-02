namespace WLED_Pixel_Art_Generator
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsSaveBtn = new System.Windows.Forms.Button();
            this.settingsCancelBtn = new System.Windows.Forms.Button();
            this.settingsUrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsSerpCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsHexCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsOnBriCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBrightnessLevelText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // settingsSaveBtn
            // 
            this.settingsSaveBtn.Location = new System.Drawing.Point(605, 644);
            this.settingsSaveBtn.Name = "settingsSaveBtn";
            this.settingsSaveBtn.Size = new System.Drawing.Size(169, 52);
            this.settingsSaveBtn.TabIndex = 7;
            this.settingsSaveBtn.Text = "Save";
            this.settingsSaveBtn.UseVisualStyleBackColor = true;
            this.settingsSaveBtn.Click += new System.EventHandler(this.settingsSaveBtn_Click);
            // 
            // settingsCancelBtn
            // 
            this.settingsCancelBtn.Location = new System.Drawing.Point(797, 644);
            this.settingsCancelBtn.Name = "settingsCancelBtn";
            this.settingsCancelBtn.Size = new System.Drawing.Size(169, 52);
            this.settingsCancelBtn.TabIndex = 6;
            this.settingsCancelBtn.Text = "Cancel";
            this.settingsCancelBtn.UseVisualStyleBackColor = true;
            this.settingsCancelBtn.Click += new System.EventHandler(this.settingsCancelBtn_Click);
            // 
            // settingsUrlText
            // 
            this.settingsUrlText.Location = new System.Drawing.Point(213, 124);
            this.settingsUrlText.Name = "settingsUrlText";
            this.settingsUrlText.Size = new System.Drawing.Size(753, 43);
            this.settingsUrlText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "WLED URL/IP";
            // 
            // settingsSerpCheckbox
            // 
            this.settingsSerpCheckbox.AutoSize = true;
            this.settingsSerpCheckbox.Checked = true;
            this.settingsSerpCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsSerpCheckbox.Location = new System.Drawing.Point(34, 290);
            this.settingsSerpCheckbox.Name = "settingsSerpCheckbox";
            this.settingsSerpCheckbox.Size = new System.Drawing.Size(176, 41);
            this.settingsSerpCheckbox.TabIndex = 8;
            this.settingsSerpCheckbox.Text = "Serpentine";
            this.settingsSerpCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsHexCheckbox
            // 
            this.settingsHexCheckbox.AutoSize = true;
            this.settingsHexCheckbox.Checked = true;
            this.settingsHexCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsHexCheckbox.Location = new System.Drawing.Point(34, 354);
            this.settingsHexCheckbox.Name = "settingsHexCheckbox";
            this.settingsHexCheckbox.Size = new System.Drawing.Size(145, 41);
            this.settingsHexCheckbox.TabIndex = 9;
            this.settingsHexCheckbox.Text = "Use Hex";
            this.settingsHexCheckbox.UseVisualStyleBackColor = true;
            // 
            // settingsOnBriCheckbox
            // 
            this.settingsOnBriCheckbox.AutoSize = true;
            this.settingsOnBriCheckbox.Checked = true;
            this.settingsOnBriCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsOnBriCheckbox.Location = new System.Drawing.Point(34, 425);
            this.settingsOnBriCheckbox.Name = "settingsOnBriCheckbox";
            this.settingsOnBriCheckbox.Size = new System.Drawing.Size(333, 41);
            this.settingsOnBriCheckbox.TabIndex = 10;
            this.settingsOnBriCheckbox.Text = "Include On/Bri Elements";
            this.settingsOnBriCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Brightness";
            // 
            // settingsBrightnessLevelText
            // 
            this.settingsBrightnessLevelText.Location = new System.Drawing.Point(213, 213);
            this.settingsBrightnessLevelText.MaxLength = 3;
            this.settingsBrightnessLevelText.Name = "settingsBrightnessLevelText";
            this.settingsBrightnessLevelText.Size = new System.Drawing.Size(79, 43);
            this.settingsBrightnessLevelText.TabIndex = 12;
            this.settingsBrightnessLevelText.Text = "25";
            this.settingsBrightnessLevelText.TextChanged += new System.EventHandler(this.settingsBrightnessLevelText_TextChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 749);
            this.Controls.Add(this.settingsBrightnessLevelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsOnBriCheckbox);
            this.Controls.Add(this.settingsHexCheckbox);
            this.Controls.Add(this.settingsSerpCheckbox);
            this.Controls.Add(this.settingsSaveBtn);
            this.Controls.Add(this.settingsCancelBtn);
            this.Controls.Add(this.settingsUrlText);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button settingsSaveBtn;
        private Button settingsCancelBtn;
        private TextBox settingsUrlText;
        private Label label1;
        private CheckBox settingsSerpCheckbox;
        private CheckBox settingsHexCheckbox;
        private CheckBox settingsOnBriCheckbox;
        private Label label2;
        private TextBox settingsBrightnessLevelText;
    }
}