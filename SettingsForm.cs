using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLED_Pixel_Art_Generator.util;

namespace WLED_Pixel_Art_Generator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsCancelBtn_Click(object sender, EventArgs e)
        {
            Form1.Instance.SetUrl(settingsUrlText.Text);
            this.Close();
        }

        private void SaveSettings()
        {
            AppSaveData saveData = new AppSaveData()
            {
                WledIp = settingsUrlText.Text,
                UseHex = settingsHexCheckbox.Checked,
                Serpentine = settingsSerpCheckbox.Checked,
                UseOnBright = settingsOnBriCheckbox.Checked,
                Brightness = int.Parse(settingsBrightnessLevelText.Text)
            };

            AppDataUtil.SaveData(saveData);
        }

        private void settingsSaveBtn_Click(object sender, EventArgs e)
        {
            if (settingsUrlText.Text.EndsWith("/"))
            {
                settingsUrlText.Text = settingsUrlText.Text.Substring(0, settingsUrlText.Text.Length - 1);
            }
            SaveSettings();
        }

        private void settingsBrightnessLevelText_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(settingsBrightnessLevelText.Text, out int value))
            {
                settingsBrightnessLevelText.Text = "";
                return;
            }
        }

        public void SetUrlFromSave(string url)
        {
            settingsUrlText.Text = url;
        }
    }

    [Serializable]
    public class AppSaveData
    {
        public string WledIp;
        public bool UseHex;
        public bool Serpentine;
        public bool UseOnBright;
        public int Brightness;
        public bool UsePython;
    }
}
