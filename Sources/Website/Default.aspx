<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyDay.Web.Default" %>
<%@ Import Namespace="MyDay.Data.IO" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/Controls/Footer.ascx" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="pageheader">
        <div class="pageicon"><span class="iconfa-user"></span></div>
        <div class="pagetitle">
            <h5>Person list</h5>
            <h1>View useful activities</h1>
        </div>
    </div>
    <div class="maincontent">
        <div class="maincontentinner">
            <h4 class="widgettitle">Persons list</h4>
            <div id="dyntable_wrapper" class="dataTables_wrapper" role="grid">
                <asp:Repeater runat="server" ID="rptPersons" OnItemCommand="RepeaterPersonsItemCommand">
                    <HeaderTemplate>
                        <table id="dyntable" class="table table-bordered dataTable">
                            <colgroup>
                                <col class="con1" />
                                <col class="con0" />
                                <col class="con1" />
                                <col class="con0" />
                                <col class="con1" />
                            </colgroup>
                            <thead>
                                <tr>
                                    <th class="head0">Name</th>
                                    <th class="head1">Email</th>
                                    <th class="head1">Activities</th>
                                    <th class="head0" class="center">Edit</th>
                                    <th class="head1" class="center">Delete</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><a href="/Person?ID=<%# ((PersonDto)Container.DataItem).Id %>"><%# ((PersonDto)Container.DataItem).Name %></a></td>
                            <td><a href="/Person?ID=<%# ((PersonDto)Container.DataItem).Id %>"><%# ((PersonDto)Container.DataItem).Email %></a></td>
                            <td class="center"><a href="/Activities?ID=<%# ((PersonDto)Container.DataItem).Id %>">Activities</a></td>
                            <td class="center"><a href="/Person?ID=<%# ((PersonDto)Container.DataItem).Id %>">Edit</a></td>
                            <td class="center">
                                <asp:LinkButton ID="LinkButton1" CommandName="Delete" OnClientClick="javascript:if(!confirm('Delete person?'))return false;" CommandArgument='<%# ((PersonDto)Container.DataItem).Id %>' runat="server">
                                    <span class="icon-trash"></span>
                                </asp:LinkButton>
                                <a href="/Delete?PersonID=<%# ((PersonDto)Container.DataItem).Id %>"></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <uc:Footer runat="server" />
        </div>
    </div>
</asp:Content>
