<%@ Page Title="Edit Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="MyDay.Web.Person" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/Controls/Footer.ascx" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI.HtmlControls" Assembly="System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="pageheader">
        <div class="pageicon"><span class="iconfa-user"></span></div>
        <div class="pagetitle">
            <h5>Edit person</h5>
            <h1>Add API connections</h1>
        </div>
    </div>
    <!--pageheader-->

            <div class="maincontent">
            <div class="maincontentinner">
                <div class="row-fluid">
					<div class="span12">
						<form action="editprofile.html" class="stdform" method="post">
							
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
							
							<div class="widgetbox services-info">
								<h4 class="widgettitle">Services information</h4>
								<div class="widgetcontent">
									<p>
										<label>Select</label>
										<span class="field inline-fields">
										    <asp:DropDownList runat="server" CssClass="uniformselect" ID="ddlTools">
										    </asp:DropDownList>
											<asp:HtmlInputText runat="server" ID="inputToolAccount" class="input-xlarge"></asp:HtmlInputText>
											<asp:LinkButton runat="server" ID="lbAddToolAccount" OnClick="AddToolAccountClick">Add</asp:LinkButton>
										</span>
									</p>
								</div>
								<h4 class="widgettitle">Persons services</h4>
								<div id="dyntable_wrapper" class="dataTables_wrapper" role="grid">
									<table id="dyntable" class="table table-bordered dataTable">
										<colgroup>
											<col class="con1" />
											<col class="con0" />
										</colgroup>
										<thead>
											<tr>
												<th class="head0">Service title</th>
												<th class="head1">System id</th>
												<th class="head0">Service action</th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td>
                                                    <img src="../include/i/icons/tp.png" width="30" height="30" class="service-icon">
                                                	<a href="http://targetprocess.colours.nl/">Target process</a>
                                                </td>
												<td><a href="http://targetprocess.colours.nl/PersonalSettings.aspx?acid=C25942C5A326C047342F8486E87C6AB0">user ID</a></td>
												<td class="center"><a href=""><span class="icon-trash"></span></a></td>
											</tr>
											<tr>
												<td>
                                                    <img src="../include/i/icons/gh.png" width="30" height="30" class="service-icon">
                                                	<a href="http://github.com/">Github</a>
                                                </td>
												<td><a href="https://github.com/garrick2k">garrick2k</a></td>
												<td class="center"><a href=""><span class="icon-trash"></span></a></td>
											</tr>
											<tr>
												<td>
                                                    <img src="../include/i/icons/ig.png" width="30" height="30" class="service-icon">
                                                	<a href="http://instagram.com/">Instagram</a>
                                                </td>
												<td><a href="https://instagram.com/">instagram account</a></td>
												<td class="center"><a href=""><span class="icon-trash"></span></a></td>
											</tr>
											<tr>
												<td>
                                                    <img src="../include/i/icons/fb.png" width="30" height="30" class="service-icon">
                                                	<a href="http://facebook.com/">Facebook</a>
                                                </td>
												<td><a href="https://www.facebook.com/igor.sivakov.7">Igor Sivakov</a></td>
												<td class="center"><a href=""><span class="icon-trash"></span></a></td>
											</tr>
										</tbody>
									</table>
								</div>
							</div>
							
							<p>
								<button type="submit" class="btn btn-primary">Update person info</button> &nbsp; <a href="">Delete person</a>
							</p>
							
						</form>
					</div><!--span12-->
				</div><!--row-fluid-->
                    
                <uc:Footer runat="server" />
                
            </div><!--maincontentinner-->
        </div><!--maincontent-->
    <asp:HiddenField runat="server" ID="hdnPerson"/>
</asp:Content>