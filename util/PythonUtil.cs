using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WLED_Pixel_Art_Generator.util
{
    public class PythonUtil
    {
        public static string GetPythonDictionary(string output)
        {
            string pattern = "^(\\w{1,})(\\s=\\s).*$";
            string replace = "'$1': $1,";

            RegexOptions options = RegexOptions.Multiline;
            
            Regex regex = new Regex(pattern, options);

            string result = regex.Replace(output, replace);

            return result.Trim().Substring(0, result.Length - 2);
        }

        public static string GetPythonArtList(string output)
        {
            string pattern = "^('\\w{1,}')(:\\s).*$";
            string replace = "$1,";

            RegexOptions options = RegexOptions.Multiline;

            Regex regex = new Regex(pattern, options);

            string result = regex.Replace(output, replace);

            return result.Trim().Substring(0, result.Length - 1);
        }
    }
}
