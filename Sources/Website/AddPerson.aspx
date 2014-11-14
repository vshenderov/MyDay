<%@ Page Title="Add Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPerson.aspx.cs" Inherits="MyDay.Web.AddPerson" %>

<%@ Register TagPrefix="uc" TagName="Footer" Src="~/Controls/Footer.ascx" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI.HtmlControls" Assembly="System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="pageheader">
        <div class="pageicon"><span class="iconfa-plus"></span></div>
        <div class="pagetitle">
            <h5>Add person</h5>
            <h1>For API integrations</h1>
        </div>
    </div>
    <div class="maincontent">
        <div class="maincontentinner">
            <div class="row-fluid">
                <div class="span12">
                    <div class="widgetbox  personal-information">
                        <h4 class="widgettitle">Person Information</h4>
                        <div class="widgetcontent">
                            <p>
                                <label>Person name:</label>
                                <asp:HtmlInputText runat="server" ID="inputName" class="input-xlarge"></asp:HtmlInputText>
                            </p>
                            <p>
                                <label>Email:</label>
                                <asp:HtmlInputText runat="server" ID="inputEmail" class="input-xlarge"></asp:HtmlInputText>
                            </p>
                        </div>
                    </div>
                    <p>
                        <asp:HtmlButton runat="server" class="btn btn-primary" OnServerClick="AddClick">Add person</asp:HtmlButton>
                    </p>
                </div>
            </div>
            <uc:Footer ID="Footer1" runat="server" />
        </div>
    </div>
</asp:Content>
