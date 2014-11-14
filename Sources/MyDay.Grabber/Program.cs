namespace MyDay.Grabber
{
    using System;
    using System.IO;
    using System.Reflection;
    using MyDay.Data;
    using MyDay.Plugin;

    public class Program
    {
        public static void Main(string[] args)
        {
            LoadPlugins();

            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var t in a.GetTypes())
                {
                    if (t.GetInterface("IMyDayGrabberPlugin") != null)
                    {
                        try
                        {
                            var pluginclass = Activator.CreateInstance(t) as IMyDayGrabberPlugin;
                            if (pluginclass != null)
                            {
                                var toolName = pluginclass.GetName();
                                var tool = Database.Tool.GetToolByName(toolName);
                                var logins = Database.PersonTool.GetLoginsByTool(tool);
                                var dateTo = DateTime.Now;
                                var dateFrom = dateTo.AddDays(-3);

                                var results = pluginclass.Grab(logins, dateFrom, dateTo);

                                foreach (var r in results)
                                {
                                    var pt = Database.PersonTool.GetPersonToolByAccount(tool, r.User);
                                    if (pt != null)
                                    
                                    {
                                        var activity = new Data.Entities.Activity();
                                        activity.Title = r.Title;
                                        activity.Content = r.Content;
                                        activity.Date = r.Time;
                                        activity.PersonId = pt.PersonId;
                                        activity.ToolId = pt.ToolId;

                                        Database.Activity.Save(activity);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Log
                        }
                    }
                }
            }

            Console.ReadKey();
        }

        public static void LoadPlugins()
        {
            var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins");

            foreach (var file in dir.GetFiles("*.dll"))
            {
                Assembly.LoadFrom(file.FullName);
            }
        }
    }
}
