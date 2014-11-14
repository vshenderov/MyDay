namespace MyDay.Grabber
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using MyDay.Plugin;

    public class Program
    {
        public static void Main(string[] args)
        {
            var accounts = new List<string> { "3", "6" };

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
                                var result = pluginclass.Grab(accounts, new DateTime(2014, 11, 12), new DateTime(2014, 11, 14));
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
