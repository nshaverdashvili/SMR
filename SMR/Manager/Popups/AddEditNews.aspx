<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditNews.aspx.cs" Inherits="SMR.Manager.Popups.AddEditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-danger alert-dismissable hidden">
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">
            x
        </button>
        <asp:Literal runat="server" ID="litMsg" />
    </div>

    <div class="col-xs-6 col-md-4">
        <div class="form-group">
            <label for="ddCategoryID">Category</label>
            <asp:DropDownList runat="server" ID="DropDownList1" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsCategory"
                DataValueField="DictionaryID" DataTextField="Caption">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="txtTitle">Title</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtTitle" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group">
            <div class="checkbox">
                <label for="chkVisible">
                    <asp:CheckBox runat="server" ID="chkVisible" ClientIDMode="Static" />
                    Is Visible</label>
            </div>
        </div>
    </div>

    <div class="col-xs-6 col-md-4">
        <div class="form-group">
            <label for="txtDate">Date</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDate" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtTitle">Video URL</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtVideoURL" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group">
             <label for="ddCategoryID">Gallery</label>
            <asp:DropDownList runat="server" ID="ddGalleryID" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsGallery"
                DataValueField="RecordID" DataTextField="Title">
            </asp:DropDownList>
           
        </div>
    </div>


    <div class="col-xs-12 col-md-12">
        <div class="form-group">
            <label for="txtDesc">Description</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDesc" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFullText">Full Text</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtFullText" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
    </div>
    <asp:Button runat="server" CssClass="btn btn-lg btn-block btn-success" ClientIDMode="Static" Text="Save" ID="btnSave" OnClick="btnSave_Click" />
    
    <asp:ObjectDataSource ID="dsGallery" runat="server" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsCategory" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="2" Name="Code" Type="Int32" />
            <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>
