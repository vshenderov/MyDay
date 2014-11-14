namespace MyDay.JsonGen
{
    using System;
    using System.Collections.Generic;
    using MyDay.Data;
    using MyDay.JsonGen.IO;
    using Newtonsoft.Json;

    public static class JsonHelper
    {
        public static string SerializeTimeline(int personId, DateTime date)
        {
            var timeline = new Timeline();
            var person = Database.Person.Get(personId);

            if (person != null)
            {
                timeline.Id = person.Name;
                timeline.Description = date.ToShortDateString();

                var activites = new List<Activity>();

                var databaseActivities = Database.Activity.GetActivities(personId);
                foreach (var databaseActivity in databaseActivities)
                {
                    var activity = new Activity();
                    activity.Title = databaseActivity.Id.ToString();
                    activity.Description = databaseActivity.Content;

                    var tool = Database.Tool.Get(databaseActivity.ToolId);
                    if (tool != null)
                    {
                        activity.Icon = tool.Icon;
                    }

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

            return JsonConvert.SerializeObject(timeline, Formatting.Indented);
        }
    }
}
