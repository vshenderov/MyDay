namespace MyDay.JsonGen.IO
{
    using Newtonsoft.Json;

    public class Activity
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("startdate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        [JsonProperty("high_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string HighThreshold { get; set; }

        [JsonProperty("importance", NullValueHandling = NullValueHandling.Ignore)]
        public string Importance { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        [JsonProperty("date_display", NullValueHandling = NullValueHandling.Ignore)]
        public string DateDisplay { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
    }
}
