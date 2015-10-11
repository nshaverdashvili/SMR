<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="SMR.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="form-group">
                <h3 class="bottom-border"><%=Core.Properties.Resources.Contact %></h3>
                <p>
                    <asp:Literal runat="server"  ID="litContacinfo" ></asp:Literal> 
                </p>
            </div>
        </div>
        <div class="row form">
           
            <div class="col-xs-6">
                <div class="form-group">
                    <label for="txtName"><%=Core.Properties.Resources.Name_ContactPage%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtName" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="txtName" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtEmail"><%=Core.Properties.Resources.Email_ContactPage%></label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="txtEmail" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="txtMessage"><%=Core.Properties.Resources.Message_ContactPage%></label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control" ID="txtMessage" ClientIDMode="Static"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="reqMessage" ControlToValidate="txtMessage" Display="Dynamic" ValidationGroup="vg" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" CssClass="btn btn-success btn-block" ID="btnSend" OnClick="btnSend_Click" />                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <asp:Literal runat="server" ID="litScripts"></asp:Literal>
</asp:Content>
