namespace MyDay.Plugin.TargetProcess
{
    using System.Configuration;
    using System.Net;

    public static class TpConnector
    {
        private static readonly WebClient WebClient = new WebClient();
        private static readonly string TpUrl = string.Empty;

        static TpConnector()
        {
            var login = ConfigurationManager.AppSettings["TargetProcess.AdminLogin"];
            var password = ConfigurationManager.AppSettings["TargetProcess.AdminPassword"];
            WebClient.Credentials = new NetworkCredential(login, password);
            TpUrl = ConfigurationManager.AppSettings["TargetProcess.Path"];
        }

        public static string GetQuery(string query, params object[] parameters)
        {
            if (!query.StartsWith(TpUrl))
            {
                query = TpUrl + query;
            }

            var queryUrl = string.Format(query, parameters);
            var xml = WebClient.DownloadString(queryUrl);

            return xml;
        }

        public static string PostQuery(string query, string value)
        {
            var postUrl = TpUrl + query;
            var result = WebClient.UploadString(postUrl, value);

            return result;
        }
    }
}
