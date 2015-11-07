<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="PublicInfo.aspx.cs" Inherits="SMR.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $(".file-groups").click(function () {
                $(this).parent().children(".file-item").toggleClass("hidden");
                return false;
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="internalContent">
                <h2  class="bottom-border">
                    საჯარო ინფორმაციის მოთხოვნა
                    <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
                </h2>
                <p class="text"><asp:Literal runat="server" ID="ltrFullText"></asp:Literal></p>
                <asp:Repeater runat="server" ID="rptFileGroups" OnItemDataBound="rptFileGroups_ItemDataBound">
                    <ItemTemplate>
                        <div>
                            <div class="file-groups fix-padding">
                                <a href="#"><i class="fa fa-bars"></i> <%#Eval("FileName") %></a>
                            </div>
                            <asp:Repeater runat="server" ID="rptFiles">
                                <ItemTemplate>
                                    <div class="file-item hidden">
                                        <a href="/Uploads/<%#Eval("URL") %>"><%#Eval("Description") %></a>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
    <div class="container-fluid main">
        <div class="row">
            <div class="form-group">
                <%--<h5 class="bottom-border"><%=Core.Properties.Resources.PublicInfo %></h5>--%>
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
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <asp:Literal runat="server" ID="litScripts"></asp:Literal>
</asp:Content>

