namespace MyDay.Web
{
    using System;
    using MyDay.Data;

    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddClick(object sender, EventArgs e)
        {
            var person = new Data.Entities.Person { Name = this.inputName.Value, Email = this.inputEmail.Value };
            Database.Person.Save(person);
            Response.Redirect("/");
        }
    }
}