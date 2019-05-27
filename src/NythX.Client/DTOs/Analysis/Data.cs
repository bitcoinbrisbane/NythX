using System;
using Newtonsoft.Json;

namespace NythX.Client.DTOs
{
    public class Data
    {
        public String ByteCode { get; set; }
        
        [JsonProperty(PropertyName = "sources")]
        public Sources Sources { get; set; }
        
        //todo:  byte array
    }
}