using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NythX.Client.DTOs;

namespace NythX.Client
{
    public class Analysis
    {
        private readonly string _api = "https://api.mythx.io/v1";
        private readonly string _path = "/auth/login";
        
        public async Task<DTOs.AnalysisResult> Submit(DTOs.Data data)
        {
            using (var client = new HttpClient())
            {
                StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("BEARER", "");
                var result = await client.PostAsync(_api + _path, content);
                String resultContent = await result.Content.ReadAsStringAsync();
                
                return Newtonsoft.Json.JsonConvert.DeserializeObject<DTOs.AnalysisResult>(resultContent);
            }
        }
    }
}