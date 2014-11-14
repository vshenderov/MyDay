namespace MyDay.JsonGen.IO
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Timeline
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("focus_date", NullValueHandling = NullValueHandling.Ignore)]
        public string FocusDate { get; set; }

        [JsonProperty("initial_zoom", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialZoom { get; set; }

        [JsonProperty("image_lane_height", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageLaneHeight { get; set; }

        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<Activity> Activites { get; set; }

        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tool> Tools { get; set; }
    }
}
