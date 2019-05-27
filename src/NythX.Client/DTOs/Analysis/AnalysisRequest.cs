using Newtonsoft.Json;

namespace NythX.Client.DTOs
{
    public class AnalysisRequest
    {
        [JsonProperty(PropertyName = "data")]
        public Data Data { get; set; }

        public AnalysisRequest()
        {
            Data = new Data();
        }
    }
}