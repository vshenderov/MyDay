namespace MyDay.JsonGen
{
    using System.Collections.Generic;

    using MyDay.JsonGen.IO;
    using Newtonsoft.Json;

    public static class JsonHelper
    {
        public static string SerializeTimeline()
        {
            var timeline = new Timeline();
            timeline.Id = "Timeline 1";

            var activites = new List<Activity>();

            activites.Add(new Activity()
                              {
                                  Id = "Activity 1",
                              });

            timeline.Activites = activites;

            
            return JsonConvert.SerializeObject(timeline, Formatting.Indented);
        }

    }
}
