using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NythX.Client.DTOs;

namespace NythX.Client
{
    public class Auth
    {
        private static string _api = "https://api.mythx.io/v1";
        private static string _path = "/auth/login";
        
        public static async Task<LoginResult> Login(String ethAddress, String password)
        {
            LoginRequest request = new LoginRequest() { EthAddress = ethAddress, Password = password };
            
            using (var client = new HttpClient())
            {
                StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(_api + _path, content);
                String resultContent = await result.Content.ReadAsStringAsync();
                
                return Newtonsoft.Json.JsonConvert.DeserializeObject<LoginResult>(resultContent);
            }
        }
    }
}