<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SMR.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <h3><%=Core.Properties.Resources.News%></h3>
        </div>
        <div class="row">
             <asp:Repeater runat="server" ID="rptNews" ItemType="Core.CM.News">
                    <ItemTemplate>
                <div class="item">
                        <div class="title">
                            <a href="<%#Item.NewsID %>"><%#Item.Title %></a>
                        </div>
                    <div class="new-content">
                    <a href="#" class="itemImg">
                        <img src="Uploads/News/2.jpg" width="125" /></a>
                    <a href="#" class="itemText">
                        <span><%#string.Format("{0:dd/MM/yyyy}", Item.NewsDate) %></span>
                        <p><%#Item.Description %></p>
                    </a>
                </div>
                <div class="line"></div>
            </div>
            </ItemTemplate>
                </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
