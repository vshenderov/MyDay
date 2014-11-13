namespace MyDay.Web
{
    using System;
    using System.Web.UI;
    using MyDay.Data;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var persons = Database.Person.GetPersons();

            Response.Write(persons[0].Name);
        }
    }
}