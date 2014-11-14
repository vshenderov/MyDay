namespace MyDay.Web
{
    using System.Web;

    using MyDay.JsonGen;

    public class JsonGenerator : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var id = context.Request.QueryString["PersonID"];
            var date = context.Request.QueryString["Date"];

            context.Response.ContentType = "application/json";
            context.Response.Write(JsonHelper.SerializeTimeline());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}