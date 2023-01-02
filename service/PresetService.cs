using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WLED_Pixel_Art_Generator.api;
using WLED_Pixel_Art_Generator.util;

namespace WLED_Pixel_Art_Generator.service
{
    public class PresetService
    {
        public string existingWledPresetJson;

        public PresetService(string json)
        {
            existingWledPresetJson = json;
        }

        public void AddNewPreset(Preset preset, string presetName)
        {
            JObject des = JsonConvert.DeserializeObject<JObject>(existingWledPresetJson);
            JObject newObject = JsonConvert.DeserializeObject<JObject>(preset.Value);

            newObject.Add("n", presetName);

            des.Add(des.Properties().Count().ToString(), newObject);
            string json = des.ToString(Formatting.None);

            AppDataUtil.BackupPreset();
            AppDataUtil.SavePreset(json);

            WledJsonApiClient apiClient = new WledJsonApiClient(Form1.Instance.Url);
            apiClient.SavePresets(json, AppDataUtil.GetPresetPath());
        }
    }

    public class Preset
    {
        public string Value;
    }
}
