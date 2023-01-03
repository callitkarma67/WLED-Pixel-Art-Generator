namespace WLED_Pixel_Art_Generator
{
    partial class SavePresetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.savePresetNameText = new System.Windows.Forms.TextBox();
            this.savePresetCancelBtn = new System.Windows.Forms.Button();
            this.savePresetSaveBtn = new System.Windows.Forms.Button();
            this.savePresetLoadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preset Name";
            // 
            // savePresetNameText
            // 
            this.savePresetNameText.Location = new System.Drawing.Point(206, 78);
            this.savePresetNameText.Name = "savePresetNameText";
            this.savePresetNameText.Size = new System.Drawing.Size(551, 43);
            this.savePresetNameText.TabIndex = 1;
            // 
            // savePresetCancelBtn
            // 
            this.savePresetCancelBtn.Location = new System.Drawing.Point(588, 175);
            this.savePresetCancelBtn.Name = "savePresetCancelBtn";
            this.savePresetCancelBtn.Size = new System.Drawing.Size(169, 52);
            this.savePresetCancelBtn.TabIndex = 2;
            this.savePresetCancelBtn.Text = "Cancel";
            this.savePresetCancelBtn.UseVisualStyleBackColor = true;
            this.savePresetCancelBtn.Click += new System.EventHandler(this.savePresetCancelBtn_Click);
            // 
            // savePresetSaveBtn
            // 
            this.savePresetSaveBtn.Location = new System.Drawing.Point(374, 175);
            this.savePresetSaveBtn.Name = "savePresetSaveBtn";
            this.savePresetSaveBtn.Size = new System.Drawing.Size(169, 52);
            this.savePresetSaveBtn.TabIndex = 3;
            this.savePresetSaveBtn.Text = "Save";
            this.savePresetSaveBtn.UseVisualStyleBackColor = true;
            this.savePresetSaveBtn.Click += new System.EventHandler(this.savePresetSaveBtn_Click);
            // 
            // savePresetLoadBtn
            // 
            this.savePresetLoadBtn.Location = new System.Drawing.Point(374, 296);
            this.savePresetLoadBtn.Name = "savePresetLoadBtn";
            this.savePresetLoadBtn.Size = new System.Drawing.Size(383, 52);
            this.savePresetLoadBtn.TabIndex = 4;
            this.savePresetLoadBtn.Text = "Fetch WLED Presets";
            this.savePresetLoadBtn.UseVisualStyleBackColor = true;
            this.savePresetLoadBtn.Click += new System.EventHandler(this.savePresetLoadBtn_Click);
            // 
            // SavePresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savePresetLoadBtn);
            this.Controls.Add(this.savePresetSaveBtn);
            this.Controls.Add(this.savePresetCancelBtn);
            this.Controls.Add(this.savePresetNameText);
            this.Controls.Add(this.label1);
            this.Name = "SavePresetForm";
            this.Text = "SavePresetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox savePresetNameText;
        private Button savePresetCancelBtn;
        private Button savePresetSaveBtn;
        private Button savePresetLoadBtn;
    }
}