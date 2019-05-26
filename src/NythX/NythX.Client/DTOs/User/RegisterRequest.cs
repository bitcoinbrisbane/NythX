using System;
using Newtonsoft.Json;

namespace NythX.Client.DTOs.User
{
    public class RegisterRequest
    {
        [JsonProperty(PropertyName = "firstName")]
        public String FirstName { get; set; } 
        
        [JsonProperty(PropertyName = "lastName")]
        public String LastName { get; set; }
        
        [JsonProperty(PropertyName = "email")]
        public String Email { get; set; }

        [JsonProperty(PropertyName = "termsId")]
        public String TermsID { get; set; }
    }
}