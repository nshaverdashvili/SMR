<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditFile.aspx.cs" Inherits="SMR.Manager.Popups.AddEditFile" %>

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

    <div class="col-xs-12">
        <div class="form-group">
            <label for="txtFileName">File Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtFileName" ClientIDMode="Static"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="valFileName" ControlToValidate="txtFileName" Display="Dynamic" 
                ErrorMessage="ფაილის სახელი სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="FileType">Type</label>
            <asp:DropDownList runat="server" ID="ddFileType" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsFileTypes"
                DataValueField="DictionaryID" DataTextField="Caption">
            </asp:DropDownList>
        </div>
         <div class="form-group">
            <label for="txtDescEN">DescriptionEN</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescriptionEN" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDescKA">DescriptionKA</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescriptionKA" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDescRU">DescriptionRU</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescriptionRU" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>


        <div class="form-group">
            <label for="fuURL">File input</label>
            <asp:FileUpload runat="server" ID="fuURL" ClientIDMode="Static" />
            <p class="help-block">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
            <p class="text-danger">
                <asp:Literal ID="litUrl" runat="server" /></p>
            <asp:HiddenField runat="server" ID="hfURL" ClientIDMode="Static" />
            <asp:RequiredFieldValidator runat="server" ID="valfuURL" ControlToValidate="fuURL" Display="Dynamic" 
                ErrorMessage="ფაილის ატვირთვა სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
        </div>
    </div>
    <asp:Button runat="server" CssClass="btn btn-lg btn-block btn-success" ClientIDMode="Static" Text="Save" ID="btnSave" OnClick="btnSave_Click" ValidationGroup="vg" />
    <asp:ObjectDataSource ID="dsFileTypes" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="1" Name="Code" Type="Int32" />
            <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
