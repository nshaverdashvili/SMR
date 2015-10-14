<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditNews.aspx.cs" ValidateRequest="false" Inherits="SMR.Manager.Popups.AddEditNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal runat="server" ID="litHead"></asp:Literal>
    <script>
       
        $(function () {
            $("#txtDate").datepicker({ dateFormat: 'yy-mm-dd' });
            $("#txtDate").prop("readonly", true);

            $(".nav-tabs a").click(function () {
                var tabgroup = $(this).data("tabgroup");


                $(".nav-tabs a[data-tabgroup='" + tabgroup + "']").parent().removeClass("active");
                $(this).parent().addClass("active");

                var tabClass = $(this).parent().parent().data("tabclass");
                var id = $(this).attr("href");

                $(tabClass).addClass("hidden");
                $(id).removeClass("hidden");

                return false;
            });
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
        <ul class="nav nav-tabs" data-tabclass=".titlegroup">
            <li role="presentation" class="active"><a href="#groupTitleEN" data-tabgroup="title">Title EN</a></li>
            <li role="presentation"><a href="#groupTitleKA" data-tabgroup="title">Title KA</a></li>
            <li role="presentation"><a href="#groupTitleRU" data-tabgroup="title">Title RU</a></li>
        </ul>
        <div class="form-group titlegroup" id="groupTitleEN">
            <label for="txtTitleEN"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleEN" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group titlegroup hidden" id="groupTitleKA">
            <label for="txtTitleKA"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group titlegroup hidden" id="groupTitleRU">
            <label for="txtTitleRU"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtTitleRU" ClientIDMode="Static"></asp:TextBox>
        </div>
         <div class="form-group" style="width:140px;">
            <label for="txtSortVal"> SortVal</label>
                <asp:TextBox runat="server" ID="txtSortVal" ClientIDMode="Static" CssClass="form-control"/>
               
        </div>
        <div class="form-group">
            <div class="checkbox">
                <label for="chkVisible">
                    <asp:CheckBox runat="server" ID="chkVisible" ClientIDMode="Static" />
                    Is Visible</label>
            </div>
        </div>
        <div class="form-group">
            <div class="checkbox">
                <label for="chkVisibleSliderEN">
                    <asp:CheckBox runat="server" ID="chkVisibleSliderEN" ClientIDMode="Static" />
                    Is Visible SliderEN</label>
            </div>
        </div>
        <div class="form-group">
            <div class="checkbox">
                <label for="chkVisibleSliderKA">
                    <asp:CheckBox runat="server" ID="chkVisibleSliderKA" ClientIDMode="Static" />
                    Is Visible SliderKA</label>
            </div>
        </div>
        <div class="form-group">
            <div class="checkbox">
                <label for="chkVisibleSliderRU">
                    <asp:CheckBox runat="server" ID="chkVisibleSliderRU" ClientIDMode="Static" />
                    Is Visible SliderRU</label>
            </div>
        </div>
       
    </div>

    <div class="col-xs-6 col-md-4">
        <div class="form-group ">
            <label for="txtDate">Date</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtDate" ClientIDMode="Static"></asp:TextBox>
            <asp:RequiredFieldValidator ErrorMessage="This field is required" ControlToValidate="txtDate" runat="server" ValidationGroup="vg" />
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

    <div class="col-xs-12 col-md-12" style="margin-bottom: 50px;">
        <ul class="nav nav-tabs" data-tabclass=".descgroup">
            <li role="presentation" class="active"><a href="#groupDescEN" data-tabgroup="desc">Description EN</a></li>
            <li role="presentation"><a href="#groupDescKA" data-tabgroup="desc">Description KA</a></li>
            <li role="presentation"><a href="#groupDescRU" data-tabgroup="desc">Description RU</a></li>
        </ul>
        <div class="form-group descgroup" id="groupDescEN">
            <label for="txtDescEN"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescEN" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group descgroup hidden" id="groupDescKA">
            <label for="txtDescKA"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group descgroup hidden" id="groupDescRU">
            <label for="txtDescRU"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescRU" ClientIDMode="Static"></asp:TextBox>
        </div>

        <!-- Full Text -->
        <ul class="nav nav-tabs" data-tabclass=".fulltxtgroup">
            <li role="presentation" class="active"><a href="#groupFulltxtEN" data-tabgroup="fulltxt">Full Text EN</a></li>
            <li role="presentation"><a href="#groupFulltxtKA" data-tabgroup="fulltxt">Full Text KA</a></li>
            <li role="presentation"><a href="#groupFulltxtRU" data-tabgroup="fulltxt">Full Text RU</a></li>
        </ul>
        <div class="form-group fulltxtgroup" id="groupFulltxtEN">
            <label for="txtFulltxtEN"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control tinymce" ID="txtFulltxtEN" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group fulltxtgroup hidden" id="groupFulltxtKA">
            <label for="txtFullTextKA"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control tinymce" ID="txtFullTextKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group fulltxtgroup hidden" id="groupFulltxtRU">
            <label for="txtFullTextRU"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control tinymce" ID="txtFullTextRU" ClientIDMode="Static"></asp:TextBox>
        </div>
    </div>
    <div class="col-xs-12 col-md-12" style="position: fixed; bottom: 1px;">
        <asp:Button runat="server" CssClass="btn btn-lg btn-block btn-success" ClientIDMode="Static" Text="Save" ID="btnSave" OnClick="btnSave_Click" ValidationGroup="vg" />
    </div>
    <asp:ObjectDataSource ID="dsGallery" runat="server" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="dsCategory" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
            <asp:Parameter DefaultValue="2" Name="Code" Type="Int32" />
            <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>
