namespace MyDay.Grabber
{
    using System;
    using System.IO;
    using System.Reflection;
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
                                var result = pluginclass.Grab();
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
