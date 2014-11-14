<%@ Page Title="Login" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyDay.Web.Login" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI.HtmlControls" Assembly="System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script type="text/javascript">
        jQuery(document).ready(function () {
            jQuery('#login').submit(function () {
                var u = jQuery('#username').val();
                var p = jQuery('#password').val();
                if (u == '' && p == '') {
                    jQuery('.login-alert').fadeIn();
                    return false;
                }
            });
        });
    </script>

    <div class="loginpanel">
        <div class="loginpanelinner">
            <div class="logo animate0 bounceIn">
                <img src="/include/i/logo.png" alt="MyDay powered by Colours,B.V." width="142" height="37" /></div>
            <form id="login" action="dashboard.html" method="post">
                <div class="inputwrapper login-alert">
                    <div class="alert alert-error">Invalid username or password</div>
                </div>
                <div class="inputwrapper animate1 bounceIn">
                    <asp:HtmlInputText runat="server" ID="inputLogin" placeholder="Enter any username"></asp:HtmlInputText>
                </div>
                <div class="inputwrapper animate2 bounceIn">
                    <asp:HtmlInputPassword runat="server" ID="inputPassword" placeholder="Enter passworde"></asp:HtmlInputPassword>
                </div>
                <div class="inputwrapper animate3 bounceIn">
                    <asp:HtmlButton runat="server" OnServerClick="LoginClick" >Sign In</asp:HtmlButton>
                </div>
                            <div class="inputwrapper animate4 bounceIn">
                <label>
                    <asp:HtmlInputCheckBox runat="server" ID="inputRemember"></asp:HtmlInputCheckBox> Keep me sign in
                </label>
            </div>
            </form>
        </div>
    </div>
</asp:Content>
