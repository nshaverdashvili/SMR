﻿<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="detailsPage.aspx.cs" Inherits="SMR.detailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
     <div class="container-fluid main">
        <div class="row">
            <div class="internalContent">
                <a href="#" class="mainImg">
                    <asp:Literal ID="ltrImgURL" runat="server"></asp:Literal>
                </a>
                <h2  class="bottom-border">
                    <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
                </h2>
                <span>
                    <asp:Literal ID="ltrDate" runat="server"></asp:Literal>
                </span>
                <p>
                    <asp:Literal ID="ltrFulltxt" runat="server"></asp:Literal>
                </p>
            </div>            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
