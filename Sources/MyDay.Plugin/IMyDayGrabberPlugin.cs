namespace MyDay.Plugin
{
    using System;
    using System.Collections.Generic;

    public interface IMyDayGrabberPlugin
    {
        List<Activity> Grab(List<string> accounts, DateTime from, DateTime to);
    }
}
