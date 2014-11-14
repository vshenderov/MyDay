<%@ Page Title="Activities" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Activities.aspx.cs" Inherits="MyDay.Web.Activities" %>

<%@ Register TagPrefix="uc" TagName="Footer" Src="~/Controls/Footer.ascx" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="pageheader">
        <div class="pageicon"><span class="iconfa-bar-chart"></span></div>
        <div class="pagetitle">
            <h5>Activities</h5>
            <h1>Grabbed from API sources</h1>
        </div>
    </div>
    <div class="maincontent">
        <div class="maincontentinner">
            <div class="row-fluid">
                <div class="span12">
                    <h4 class="widgettitle">Person timeline</h4>
                    <div class="person-timeline" id="person-timeline">
                    </div>
                </div>
            </div>
            <uc:Footer runat="server" />
        </div>
    </div>
    <script>
        if (jQuery('#person-timeline').length) {
            var tg1 = jQuery("#person-timeline").timeline({
                "data_source": "http://myday.local/activities.json?PersonID=<%=PersonId%>",
                "icon_folder": "/include/i/icons/",
                "constrain_to_data": true,
                "show_footer": false,
                "loaded": function () {
                },
            });
        }
    </script>
</asp:Content>
