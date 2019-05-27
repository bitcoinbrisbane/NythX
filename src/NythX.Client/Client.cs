using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NythX.Client.DTOs;

namespace NythX.Client
{
    public class Client
    {
        private string _access;
        private readonly String _ethAddress;
        private readonly String _password;
        
        private readonly string _api = "https://api.mythx.io/v1";
        //private readonly string _path = "/auth/login";
        
        public Client(String ethAddress, String password)
        {
            _ethAddress = ethAddress;
            _password = password;
        }

        public async Task<LoginResult> Login()
        {
            LoginResult result = await Auth.Login(_ethAddress, _password);
            this._access = result.Access;
            return result;
        }
        
        public async Task<DTOs.AnalysisResult> Submit(AnalysisRequest request)
        {
            using (var client = new HttpClient())
            {
                StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _access);
                
                var result = await client.PostAsync(_api + "/analyses", content);
                String resultContent = await result.Content.ReadAsStringAsync();
                
                return Newtonsoft.Json.JsonConvert.DeserializeObject<DTOs.AnalysisResult>(resultContent);
            }
        }
        
        public async Task<String> Get(Guid uuid)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _access);
                
                var result = await client.GetStringAsync(_api + "/analyses/" + uuid);
                return result;
                //return Newtonsoft.Json.JsonConvert.DeserializeObject<DTOs.AnalysisResult>(result);
            }
        }
    }
}