namespace MyDay.Web
{
    using System;
    using System.Web.UI;
    using MyDay.Data;
    using MyDay.Data.Entities;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var p = new Person();
            //p.Name = "Test 1";
            //p.Email = "Test 1";

            //Database.Person.Save(p);

            var persons = Database.Person.GetPersons();

            Response.Write(persons[0].Name);
        }
    }
}