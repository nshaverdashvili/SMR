<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditFile.aspx.cs" Inherits="SMR.Manager.Popups.AddEditFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-danger alert-dismissable hidden">
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">x
        </button>
        <asp:Literal runat="server" ID="litMsg" />
    </div>
    
    <div class="form-group">
    <label for="txtFileName">File Name</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="txtFileName" ClientIDMode="Static"></asp:TextBox>
   </div>
    <div class="form-group">
        <label for="FileType">Type</label>
        <asp:DropDownList runat="server" ID="ddFileType" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsFileTypes" 
            DataValueField="DictionaryID" DataTextField="Caption">
        </asp:DropDownList>
    </div>
    <div class="form-group">
    <label for="txtDesc">Description</label>
    <asp:TextBox runat="server" CssClass="form-control" ID="txtDesc" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
   </div>
    
    <div class="form-group">
    <label for="fuURL">File input</label>
    <asp:FileUpload runat="server" ID="fuURL" ClientIDMode="Static" />
    <p class="help-block" >დასაშვები ფაილებია: jpg, png, pdf, doc</p>
    <p class="text-danger" ><asp:Literal ID="litUrl" runat="server" /></p>
    <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
  </div>
  <asp:Button runat="server" CssClass="btn btn-lg btn-block btn-success" ClientIDMode="Static" Text="Save" ID="btnSave" OnClick="btnSave_Click" />
<asp:ObjectDataSource ID="dsFileTypes" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
    <SelectParameters>
        <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
        <asp:Parameter DefaultValue="1" Name="Code" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
    </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
