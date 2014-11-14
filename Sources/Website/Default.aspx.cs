namespace MyDay.Web
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using MyDay.Data;

    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UpdateList();
        }

        protected void RepeaterPersonsItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete" && e.CommandArgument.ToString() != string.Empty)
            {
                var id = 0;
                int.TryParse(e.CommandArgument.ToString(), out id);
                var person = Database.Person.Get(id);
                Database.Person.Delete(person);

                this.UpdateList();
            }
        }

        private void UpdateList()
        {
            this.rptPersons.DataSource = Database.Person.GetPersons();
            this.rptPersons.DataBind();
        }
    }
}