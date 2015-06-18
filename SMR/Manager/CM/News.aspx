<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="SMR.Manager.CM.News" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <button type="button" class="btn btn-success" id="btnAddnew" ><%=Core.Properties.Resources.CreateNew %> </button>
    </div>
    <div class="row">
        <dx:ASPxGridView ID="gridNews" ClientInstanceName="gridNews" runat="server" AutoGenerateColumns="False" DataSourceID="dsNews" Width="100%" KeyFieldName="NewsID" >
            <Columns>                
                <dx:GridViewDataDateColumn FieldName="NewsDate" >
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataTextColumn FieldName="Title" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Description" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="FullText" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="LangID" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="SortVal" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="IsVisible" >
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataTextColumn FieldName="VideoURL" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="true" ShowNewButtonInHeader="false" ButtonType="image" Caption=" ">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataComboBoxColumn FieldName="CategoryID" VisibleIndex="5">
                    <PropertiesComboBox DataSourceID="dsCategories" TextField="Caption" ValueField="DictionaryID">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataComboBoxColumn FieldName="GalleryID" VisibleIndex="9">
                    <PropertiesComboBox DataSourceID="dsGalleries" TextField="Title" ValueField="RecordID">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
            </Columns>
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsNews" runat="server" DeleteMethod="SP_News" InsertMethod="SP_News" SelectMethod="ListNews" TypeName="Core.CM.NewsRepository" UpdateMethod="SP_News">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="2" />
                <asp:Parameter Name="NewsID" Type="Int32" />
                <asp:Parameter Name="NewsDate" Type="DateTime" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="FullText" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="SortVal" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
                <asp:Parameter Name="VideoURL" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="0" />
                <asp:Parameter Name="NewsID" Type="Int32" />
                <asp:Parameter Name="NewsDate" Type="DateTime" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="FullText" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="SortVal" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
                <asp:Parameter Name="VideoURL" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="1"/>
                <asp:Parameter Name="NewsID" Type="Int32" />
                <asp:Parameter Name="NewsDate" Type="DateTime" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="FullText" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="SortVal" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
                <asp:Parameter Name="VideoURL" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsCategories" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
                <asp:Parameter DefaultValue="2" Name="Code" Type="Int32" />
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
                gridNews.AddNewRow();
            });

        });
    </script>
</asp:Content>
