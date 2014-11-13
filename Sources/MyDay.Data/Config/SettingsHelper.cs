namespace MyDay.Data.Config
{
    using System.Web.Configuration;

    public static class SettingsHelper
    {
        public static string DataDbConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["MyDay"].ConnectionString;
            }
        }
    }
}
