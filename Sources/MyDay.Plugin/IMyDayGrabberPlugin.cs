namespace MyDay.Plugin
{
    using System.Collections.Generic;

    public interface IMyDayGrabberPlugin
    {
        List<Activity> Grab();
    }
}
