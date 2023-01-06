using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLED_Pixel_Art_Generator.util
{
    public class HassUtil
    {
        private static string _hassId = "wled_pixel_art_";
        private static string _friendlyName = "Pixel Art ";
        private static string _commandOn = $"curl -X POST \"{Form1.Instance.Url}/json/state\" -d '";
        private static string _commandOff = $"curl -X POST \"{Form1.Instance.Url}\" -d '{{\"on\":false}}' -H \"Content-Type: application/json\"";
        private static string _yamlStarter = "- platform: command_line" + Environment.NewLine + "  switches:";
        private static string _result = "";

        public static string GetHassSwitch(string json, string fileName, bool isBulk)
        {
            string result = "";
            _hassId += fileName.ToLower();
            _friendlyName += fileName;
            _commandOn += json + "' -H \"Content-Type: application/json\"";

            if (!_result.Contains(_yamlStarter))
            {
                result += _yamlStarter + Environment.NewLine + "    " + _hassId + ":" + Environment.NewLine;
            }
            else
            {
                result += "    " + _hassId + ":" + Environment.NewLine;
            }

            result += "      friendly_name: " + _friendlyName + Environment.NewLine + "      command_on: >" + Environment.NewLine + "        " + _commandOn + Environment.NewLine;
            result += "      command_off: >" + Environment.NewLine + "        " + _commandOff + Environment.NewLine + Environment.NewLine;

            _result += result;
            if (isBulk)
                ResetFields();

            return result;
        }

        public static string ToggleYamlStarter(bool toggle)
        {
            if (toggle)
            {
                return _result;
            } else
            {
                return _result.Replace(_yamlStarter, "");
            }
        }

        private static void ResetFields()
        {
            _hassId = "wled_pixel_art_";
            _friendlyName = "Pixel Art ";
            _commandOn = $"curl -X POST \"{Form1.Instance.Url}/json/state\" -d '";
        }

        public static void Reset()
        {
            _result = "";
            ResetFields();
        }
    }
}
