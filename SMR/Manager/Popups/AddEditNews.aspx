<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditNews.aspx.cs" Inherits="SMR.Manager.Popups.AddEditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal runat="server" ID="litHead"></asp:Literal>
    <script>
        tinymce.init({
            selector: ".tinymce",
            menubar: false,
            paste_word_valid_elements: "b,strong,i,h1,h2",
            toolbar: "bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | media code",
            plugins: "fullscreen,media,code",
            forced_root_block: false,
            force_p_newlines: false,
            remove_linebreaks: false,
            force_br_newlines: true,
            remove_trailing_nbsp: false,
            verify_html: false
        });
        $(function () {
            $("#txtDate").datepicker({ dateFormat: 'dd/mm/yy' });
            $("#txtDate").prop("readonly", true);
        });
    </script>
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
    

    <div class="col-xs-6 col-md-4">
        <div class="form-group">
            <label for="ddCategoryID">Category</label>
            <asp:DropDownList runat="server" ID="ddCategoryID" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsCategory"
                DataValueField="DictionaryID" DataTextField="Caption">
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="txtTitleEN">Title EN</label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleEN" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtTitleKA">Title KA</label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-groupRU">
            <label for="txtTitleRU">Title RU</label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleRU" ClientIDMode="Static"></asp:TextBox>
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
        <div class="form-group ">
            <label for="txtDate">Date</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDate" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group ">
            <label for="txtVideoURL">Video URL</label>
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
            <label for="txtDescEN">Description EN</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescEN" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDescKA">Description KA</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescKA" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtDescRU">Description RU</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDescRU" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFullTextEN">Full Text</label>
            <asp:TextBox runat="server" CssClass="form-control tinymce" ID="txtFullTextEN" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFullTextKA">Full Text</label>
            <asp:TextBox runat="server" CssClass="form-control tinymce" ID="txtFullTextKA" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtFullTextRU">Full Text</label>
            <asp:TextBox runat="server" CssClass="form-control tinymce" ID="txtFullTextRU" ClientIDMode="Static" TextMode="MultiLine" Rows="5"></asp:TextBox>
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
