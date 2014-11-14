namespace MyDay.Plugin.GitHub
{
    using System;
    using System.Collections.Generic;

    public class GitHubGrabber : IMyDayGrabberPlugin
    {
        public string GetName()
        {
            return "GitHub";
        }

        public List<Activity> Grab(List<string> accounts, DateTime from, DateTime to)
        {
            var list = new List<Activity>();

            for (int i = 0; i < 4; i++)
            {
                list.Add(new Activity()
                {
                    User = "valikvs",
                    Title = "Commit on Nov 14, 2014",
                    Content = "Merge branch 'dev' of github.com:vshenderov/MyDay into dev",
                    Time = from.AddHours(i * 2),
                });
            }

            return list;
        }
    }
}
