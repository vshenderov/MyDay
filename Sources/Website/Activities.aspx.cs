namespace MyDay.Web
{
    using System;

    public partial class Activities : System.Web.UI.Page
    {
        protected int PersonId
        {
            get
            {
                var id = 0;

                if (Request.QueryString["ID"] != null)
                {
                    int.TryParse(Request.QueryString["ID"], out id);
                }

                return id;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}