namespace MyDay.Web
{
    using System;
    using System.Web.Security;

    public partial class Login : System.Web.UI.Page
    {
        protected bool Authenticate(string login, string password)
        {
            return login == "admin"
                   && password == "b";
        }

        protected void LoginClick(object sender, EventArgs e)
        {
            if (this.Authenticate(this.inputLogin.Value, this.inputPassword.Value))
            {
                FormsAuthentication.RedirectFromLoginPage(this.inputLogin.Value, this.inputRemember.Checked);
            }
        }
    }
}