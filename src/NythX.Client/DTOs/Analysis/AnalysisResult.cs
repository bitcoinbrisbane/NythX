using System;
using Newtonsoft.Json;

namespace NythX.Client.DTOs
{
    public class AnalysisResult
    {
        [JsonProperty(PropertyName = "apiVersion")]
        public String ApiVersion { get; set; }
        
        [JsonProperty(PropertyName = "harveyVersion")]
        public String HarveyVersion { get; set; }
        
        [JsonProperty(PropertyName = "maestroVersion")]
        public String MaestroVersion { get; set; }
        
        [JsonProperty(PropertyName = "maruVersion")]
        public String MaruVersion { get; set; }
        
        [JsonProperty(PropertyName = "mythrilVersion")]
        public String MythrilVersion { get; set; }
        
        [JsonProperty(PropertyName = "queueTime")]
        public Int32 QueueTime { get; set; }
        
        [JsonProperty(PropertyName = "status")]
        public String Status { get; set; }
        
        [JsonProperty(PropertyName = "submittedAt")]
        public DateTime SubmittedAt { get; set; }
        
        [JsonProperty(PropertyName = "submittedBy")]
        public String SubmittedBy { get; set; }
        
        [JsonProperty(PropertyName = "uuid")]
        public Guid Uuid { get; set; }
    }
}