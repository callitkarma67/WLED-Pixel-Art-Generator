using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLED_Pixel_Art_Generator.api;
using WLED_Pixel_Art_Generator.service;
using WLED_Pixel_Art_Generator.util;

namespace WLED_Pixel_Art_Generator
{
    public partial class SavePresetForm : Form
    {
        public string PresetJson;
        public SavePresetForm()
        {
            InitializeComponent();
            Form1.Instance.SetPresetSaved(false);
        }

        private void savePresetCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savePresetSaveBtn_Click(object sender, EventArgs e)
        {
            string localJson = AppDataUtil.LoadPreset();
            string presetName = savePresetNameText.Text;

            if (presetName.Length <= 0)
            {
                presetName = $"MyNewPreset_{localJson.Length + 1}";
            }
            if (localJson.Length > 0)
            {
                PresetService preset = new PresetService(localJson);
                preset.AddNewPreset(new Preset
                {
                    Value = PresetJson
                }, presetName);
            }
            else
            {
                WledJsonApiClient wled = new WledJsonApiClient(Form1.Instance.Url);
                string presetJson = wled.GetPresets();

                PresetService presetService = new PresetService(presetJson);
                presetService.AddNewPreset(new Preset
                {
                    Value = PresetJson
                }, presetName);
            }

            Form1.Instance.SetPresetSaved(true);

            this.Close();
        }

        private void savePresetLoadBtn_Click(object sender, EventArgs e)
        {
            WledJsonApiClient wled = new WledJsonApiClient(Form1.Instance.Url);
            string presetJson = wled.GetPresets();

            AppDataUtil.SavePreset(presetJson, "presets_manual_backup.json");
        }
    }
}
