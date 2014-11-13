namespace MyDay.Plugin.TargetProcess
{
    using System;
    using System.Collections.Generic;

    public class TargetProcessGrabber : IMyDayGrabberPlugin
    {
        public List<Activity> Grab()
        {
            var list = new List<Activity>();
            list.Add(new Activity()
                         {
                             User = "vns",
                             Content = "test content",
                             Time = new DateTime()
                         });

            return list;
        }
    }
}
