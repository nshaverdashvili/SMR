<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="SMR.NewsList" %>

<%@ MasterType TypeName="SMR.CMMaster" %>
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
                            <a href="/NewsDetails.aspx?ID=<%#Item.NewsID %>"><%#Item.Title %></a>
                        </div>
                        <div class="new-content">
                            <a href="/NewsDetails.aspx?ID=<%#Item.NewsID %>" class="itemImg">
                                <img src="Uploads/<%#Item.ImgURL%>?w=125&mode=stretch" /></a>
                            <a href="/NewsDetails.aspx?ID=<%#Item.NewsID %>" class="itemText">
                                <span><%#string.Format("{0:dd/MM/yyyy}", Item.NewsDate) %></span>
                                <p><%#Item.Description %></p>
                            </a>
                        </div>
                        <div class="line"></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="row paging">
            <asp:PlaceHolder ID="plcPaging" runat="server" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
