namespace MyDay.JsonGen.IO
{
    using Newtonsoft.Json;

    public class Tool
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
    }
}
