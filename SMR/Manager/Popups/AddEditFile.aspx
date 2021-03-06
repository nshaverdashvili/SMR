﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Popups/PopupMaster.Master" AutoEventWireup="true" CodeBehind="AddEditFile.aspx.cs" Inherits="SMR.Manager.Popups.AddEditFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal runat="server" ID="litHead"></asp:Literal>
    <script>
        $(function () {
            $(".nav-tabs a").click(function () {

                $(".nav-tabs a").parent().removeClass("active");
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

    <div class="col-xs-12">
        <%-- <div class="form-group">
            <label for="txtFileName">File Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtFileName" ClientIDMode="Static"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="valFileName" ControlToValidate="txtFileName" Display="Dynamic"
                ErrorMessage="ფაილის სახელი სავალდებულოა" CssClass="text-danger" ValidationGroup="vg"></asp:RequiredFieldValidator>
        </div>--%>

        <!--FileNames -->
        <ul class="nav nav-tabs" data-tabclass=".FileNamegroup">
            <li role="presentation" class="active"><a href="#groupFileNameEN">FileName EN</a></li>
            <li role="presentation"><a href="#groupFileNameKA">FileName KA</a></li>
            <li role="presentation"><a href="#groupFileNameRU">FileName RU</a></li>
        </ul>
        <div class="form-group FileNamegroup" id="groupFileNameEN">
            <label for="txtFileNameEn"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtFileNameEn" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group FileNamegroup hidden" id="groupFileNameKA">
            <label for="txtFileNameKA"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtFileNameKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group FileNamegroup hidden" id="groupFileNameRU">
            <label for="txtFileNameRU"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtFileNameRU" ClientIDMode="Static"></asp:TextBox>
        </div>
    </div>
    <!--FileNames -->
    <div class="form-group">
        <label for="FileType">Type</label>
        <asp:DropDownList runat="server" ID="ddFileType" ClientIDMode="Static" CssClass="form-control" DataSourceID="dsFileTypes"
            DataValueField="DictionaryID" DataTextField="Caption">
        </asp:DropDownList>
    </div>
    <ul class="nav nav-tabs" data-tabclass=".descgroup">
        <li role="presentation" class="active"><a href="#groupDescEN">Description EN</a></li>
        <li role="presentation"><a href="#groupDescKA">Description KA</a></li>
        <li role="presentation"><a href="#groupDescRU">Description RU</a></li>
    </ul>
    <div>
        <div class="form-group descgroup" id="groupDescEN">
            <label for="txtDescriptionEN"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescriptionEN" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group descgroup hidden" id="groupDescKA">
            <label for="txtDescriptionKA"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescriptionKA" ClientIDMode="Static"></asp:TextBox>
        </div>
        <div class="form-group descgroup hidden" id="groupDescRU">
            <label for="txtDescriptionRU"></label>
            <asp:TextBox runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" ID="txtDescriptionRU" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="fuURLka">File input ka</label>
            <asp:FileUpload runat="server" ID="fuURLka" ClientIDMode="Static" />
            <p class="help-block">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
            <p class="text-danger">
                <asp:Literal ID="litUrlka" runat="server" />
            </p>
            <asp:HiddenField runat="server" ID="hfURLka" ClientIDMode="Static" />
        </div>

        <div class="form-group">
            <label for="fuURLen">File input en</label>
            <asp:FileUpload runat="server" ID="fuURLen" ClientIDMode="Static" />
            <p class="help-block">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
            <p class="text-danger">
                <asp:Literal ID="litUrlen" runat="server" />
            </p>
            <asp:HiddenField runat="server" ID="hfURLen" ClientIDMode="Static" />
        </div>

        <div class="form-group">
            <label for="fuURL">File input ru</label>
            <asp:FileUpload runat="server" ID="fuURLru" ClientIDMode="Static" />
            <p class="help-block">დასაშვები ფაილებია: jpg, png, pdf, doc</p>
            <p class="text-danger">
                <asp:Literal ID="litUrlru" runat="server" />
            </p>
            <asp:HiddenField runat="server" ID="hfURLru" ClientIDMode="Static" />
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
    </div>
</asp:Content>
