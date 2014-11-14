namespace MyDay.Web
{
    using System;
    using System.Web;
    using MyDay.JsonGen;

    public class JsonGenerator : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            var idParam = context.Request.QueryString["PersonID"];
            int id;
            int.TryParse(idParam, out id);

            var dateParam = context.Request.QueryString["Date"];
            var date = DateTime.Parse(dateParam);

            context.Response.ContentType = "application/json";
            context.Response.Write(JsonHelper.SerializeTimeline(id, date));
        }
    }
}