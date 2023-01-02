using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WLED_Pixel_Art_Generator.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WLED_Pixel_Art_Generator.api
{
    internal class WledJsonApiClient
    {
        
        private string _url;

        public WledJsonApiClient(string url)
        {
            _url = url;
        }

        public void postToWled(string body)
        {
            var http = new RestClient(_url);
            http.AddDefaultHeader("Content-Type", "application/json");

            var request = new RestRequest("/json/state", Method.Post);
            request.AddStringBody(body, DataFormat.Json);

            try
            {
                http.ExecuteAsync(request);
            } catch (Exception ex)
            {
                MessageBox.Show("Error occurred during post :: " + ex.Message);
            }
            
        }

        public void wledOff()
        {
            var http = new RestClient(_url);
            http.AddDefaultHeader("Content-Type", "application/json");

            var request = new RestRequest("/json/state", Method.Post);
            request.AddStringBody("{\"on\": false}", DataFormat.Json);

            try
            {
                http.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during OFF post :: " + ex.Message);
            }
        }

        public void SavePresets(string json, string presetFilePath)
        {
            var http = new RestClient(_url);

            var request = new RestRequest("/edit", Method.Post);
            
            request.AddFile("filename", presetFilePath);
            request.AlwaysMultipartFormData = true;

            try
            {
                http.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during SavePresets post :: " + ex.Message);
            }
        }

        public string GetPresets()
        {
            string param = "/edit?edit=/presets.json";
            var http = new RestClient(_url);
            var request = new RestRequest(_url + param, Method.Get);

            var resp = http.Execute(request);

            return resp.Content;
        }
    }
}
