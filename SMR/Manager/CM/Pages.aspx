<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Pages.aspx.cs" Inherits="SMR.Manager.CM.Pages" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <div class="col-xs-12" style="margin: 20px 0;">
            <button type="button" class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %> </button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
            <dx:ASPxGridView ID="gridPages" ClientInstanceName="gridPages" runat="server" AutoGenerateColumns="False" DataSourceID="dsPages" KeyFieldName="PageID" Width="100%">
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="TitleEN">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TitleKA">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TitleRU">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DescriptionEN">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DescriptionKA">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DescriptionRU">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="URL">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Note">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="IsVisible">
                    </dx:GridViewDataCheckColumn>
                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="true" ShowNewButtonInHeader="false" ButtonType="image" Caption=" ">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="TemplateID" VisibleIndex="3">
                        <PropertiesComboBox DataSourceID="dsTemplates" TextField="Caption" ValueField="DictionaryID">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataComboBoxColumn FieldName="GalleryID" VisibleIndex="6">
                        <PropertiesComboBox DataSourceID="dsGalleries" TextField="Title" ValueField="RecordID">
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                </Columns>
            </dx:ASPxGridView>
        </div>
        <asp:ObjectDataSource ID="dsPages" runat="server" DeleteMethod="SP_Pages" InsertMethod="SP_Pages" SelectMethod="ListPages" TypeName="Core.CM.PagesRepository" UpdateMethod="SP_Pages">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="2" />
                <asp:Parameter Name="PageID" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="TemplateID" Type="Int32" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="Note" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="0" />
                <asp:Parameter Name="PageID" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="TemplateID" Type="Int32" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="Note" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="1" />
                <asp:Parameter Name="PageID" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="TemplateID" Type="Int32" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="Note" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsTemplates" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
                <asp:Parameter DefaultValue="3" Name="Code" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsGalleries" runat="server" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository"></asp:ObjectDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {
            $("#btnAddnew").click(function () {
                gridPages.AddNewRow();
            });

        });
    </script>
</asp:Content>
