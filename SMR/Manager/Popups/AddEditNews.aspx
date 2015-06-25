<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditNews.aspx.cs" Inherits="SMR.Manager.Popups.AddEditNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="bg-danger"><asp:Literal runat="server" ID ="litMsg"/></p>
     <div class="form-group">
         <label for="ddCategoryID">Category</label>
         <asp:DropDownList runat="server" ID="ddCategoryID" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsCategory" 
                DataValueField="DictionaryID" DataTextField="Caption">
            </asp:DropDownList>
     </div>
    <!--date-->
    <div class="form-group">
        <label for="txtTitle">Title</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtTitle" ClientIDMode="Static"></asp:TextBox>
   </div>
    <div class="form-group">
        <label for="txtDesc">Description</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtDesc" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
   </div>
    <div class="form-group">
        <label for="txtFullText">Full Text</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtFullText" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
   </div>

    <asp:ObjectDataSource ID="dsLang" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
        <asp:Parameter DefaultValue="4" Name="Code" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
    </SelectParameters>
    </asp:ObjectDataSource>


    <asp:ObjectDataSource ID="dsGallery" runat="server" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="dsCategory" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
        <asp:Parameter DefaultValue="2" Name="Code" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
    </SelectParameters>
    </asp:ObjectDataSource>

    <div class="form-group">
    <label for="VideoURL">Video URL</label>
    <asp:FileUpload runat="server" ID="VideoURL" ClientIDMode="Static" />
    <p class="help-block" >დასაშვები ფაილებია: jpg, png, pdf, doc</p>
    <p class="text-danger" ><asp:Literal ID="litUrl" runat="server" /></p>
    <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
  </div>
<asp:Button runat="server" CssClass="btn btn-blobtn-success" ClientIDMode="Static" Text="Save" ID="btnSave" OnClick="btnSave_Click" />

</asp:Content>
