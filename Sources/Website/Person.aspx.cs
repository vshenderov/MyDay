namespace MyDay.Web
{
    using System;
    using System.Globalization;
    using System.Web.UI.WebControls;
    using MyDay.Data;

    public partial class Person : System.Web.UI.Page
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
            var p = Database.Person.Get(this.PersonId);
            if (p != null)
            {
                this.inputName.Value = p.Name;
                this.inputEmail.Value = p.Email;

                this.hdnPerson.Value = p.Id.ToString(CultureInfo.InvariantCulture);
            }

            if (!this.IsPostBack)
            {
                var tools = Database.Tool.Select();

                foreach (var tool in tools)
                {
                    this.ddlTools.Items.Add(new ListItem(tool.Name, tool.Id.ToString(CultureInfo.InvariantCulture)));
                }

                this.UpdateList();
            }
        }

        protected void AddToolAccountClick(object sender, EventArgs e)
        {
            var toolId = 0;
            int.TryParse(this.ddlTools.SelectedValue, out toolId);
            var tool = Database.Tool.Get(toolId);

            var personId = 0;
            int.TryParse(this.hdnPerson.Value, out personId);
            var person = Database.Person.Get(personId);

            if (tool != null && person != null)
            {
                var pt = new Data.Entities.PersonTool
                             {
                                 PersonId = person.Id,
                                 ToolId = toolId,
                                 Account = this.inputToolAccount.Value
                             };

                Database.PersonTool.Save(pt);
            }

            Response.Redirect("/Person?ID=" + this.PersonId);
        }

        protected void RepeaterAccountsItemCommand(object source, RepeaterCommandEventArgs e)
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
            var personId = 0;
            int.TryParse(this.hdnPerson.Value, out personId);
            var person = Database.Person.Get(personId);

            this.rptAccounts.DataSource = Database.PersonTool.GetAccounts(person);
            this.rptAccounts.DataBind();
        }
    }
}