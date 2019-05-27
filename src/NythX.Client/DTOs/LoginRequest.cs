using System;
using Newtonsoft.Json;

namespace NythX.Client.DTOs
{
    public class LoginRequest
    {
        [JsonProperty(PropertyName = "ethAddress")]
        public String EthAddress { get; set; }
        
        [JsonProperty(PropertyName = "password")]
        public String Password { get; set; }
    }
}