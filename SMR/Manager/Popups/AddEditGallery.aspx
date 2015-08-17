<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditGallery.aspx.cs" Inherits="SMR.Manager.Popups.AddEditGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PlaceHolder runat="server" ID="msgPH" Visible="false">
        <div class="alert alert-danger alert-dismissable">
            <button type="button" class="close" data-dismiss="alert" aria-hidden="true">
                x
            </button>
            <asp:Literal runat="server" ID="litMsg" />
        </div>
    </asp:PlaceHolder>

    <div class="form-group">
        <label for="txtTitleEN">TitleEN</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtTitleEN" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtTitleKA">TitleKA</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtTitleKA" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtTitleRU">TitleRU</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtTitleRU" ClientIDMode="Static"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtDescEN">DescriptionEN</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtDescEN" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtDescKA">DescriptionKA</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="DescriptionKA" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="txtDescRU">DescriptionRU</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="DescriptionRU" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
    </div>


</asp:Content>
