using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WLED_Pixel_Art_Generator.util
{
    public class AppDataUtil
    {
        private static string documentRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string dataFolder = documentRoot + "\\WLED_Pixel_Art_Generator\\";

        public static string GetPresetPath()
        {
            return dataFolder + "presets.json";
        }

        public static AppSaveData LoadSaveData()
        {
            return Deserialize();
        }

        public static void SaveData(AppSaveData saveData)
        {
            Serialize(saveData);
        }

        public static void SavePreset(string presetJson, string fileName="presets.json")
        {
            FileStream s;
            
            if (!File.Exists(dataFolder + fileName))
            {
                
                if (!Directory.Exists(dataFolder))
                {
                    
                    Directory.CreateDirectory(dataFolder);
                }
                s = File.Create(dataFolder + fileName);
                s.Close();
            } else
            {
                File.WriteAllText(dataFolder + fileName, String.Empty);
            }
            
            using (StreamWriter sw = new StreamWriter(dataFolder + fileName)) {

                sw.Write(presetJson);
                sw.Close();
            }
        }

        public static string LoadPreset()
        {
            if (!File.Exists(dataFolder + "presets.json"))
            {
                return "";
            }

            return File.ReadAllText(dataFolder + "presets.json");
        }

        public static void BackupPreset()
        {
            string existingPreset = LoadPreset();
            if (existingPreset.Length <= 0)
            {
                return;
            }
            SavePreset(existingPreset, "presets.json.BAK");
        }

        private static AppSaveData Deserialize()
        {
            if (!File.Exists(dataFolder + "data.sav")) {
                return new AppSaveData()
                {
                    WledIp = "",
                    UseHex= true,
                    Serpentine = true,
                    UseOnBright = true,
                    Brightness = 25
                };
            }   
            Stream s = File.OpenRead(dataFolder + "data.sav");
            BinaryFormatter b = new BinaryFormatter();
            AppSaveData data = (AppSaveData)b.Deserialize(s);
            
            s.Close();
            return data;
        }

        private static void Serialize(AppSaveData data)
        {
            FileStream s;
            string fileName = "data.sav";
            
            if (!File.Exists(dataFolder + fileName))
            {
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }
                s = File.Create(dataFolder + fileName);
                s.Close();
            }
            s = File.Open(dataFolder + fileName, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            
            
            b.Serialize(s, data);
            s.Close();
        }
    }
}
