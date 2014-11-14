namespace MyDay.JsonGen
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using MyDay.Data;
    using MyDay.JsonGen.IO;
    using Newtonsoft.Json;

    public static class JsonHelper
    {
        public static string SerializeTimeline(int personId, DateTime date)
        {
            var timelines = new List<Timeline>();
            var timeline = new Timeline();
            var person = Database.Person.Get(personId);

            if (person != null)
            {
                timeline.Id = person.Name;
                timeline.Title = person.Name;

                var activites = new List<Activity>();

                var databaseActivities = Database.Activity.GetActivities(personId);
                foreach (var databaseActivity in databaseActivities)
                {
                    var activity = new Activity();
                    activity.Title = databaseActivity.Title;
                    activity.Description = databaseActivity.Content;

                    var tool = Database.Tool.Get(databaseActivity.ToolId);
                    if (tool != null)
                    {
                        activity.Icon = tool.Icon;
                    }

                    activity.Id = databaseActivity.Id.ToString(CultureInfo.InvariantCulture);
                    activity.Importance = "20";
                    activity.DateDisplay = "hour";
                    activity.StartDate = databaseActivity.Date.ToString("yyyy-MM-dd H:mm:ss");

                    activites.Add(activity);
                }

                timeline.Activites = activites;

                var tools = new List<Tool>();

                var databaseTools = Database.Tool.Select();
                foreach (var databaseTool in databaseTools)
                {
                    var tool = new Tool { Title = databaseTool.Name, Icon = databaseTool.Icon };

                    tools.Add(tool);
                }

                timeline.Tools = tools;
            }

            timelines.Add(timeline);

            return JsonConvert.SerializeObject(timelines, Formatting.Indented);
        }
    }
}
