<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="SMR.Manager.CM.News" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal ID="litHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <div class="col-xs-12" style="margin:20px 0;">
            <button type="button" class="btn btn-success" id="btnAddnew" ><%=Core.Properties.Resources.CreateNew %> </button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
         <dx:ASPxGridView ID="gridNews" ClientInstanceName="gridNews" runat="server" AutoGenerateColumns="False" DataSourceID="dsNews" Width="100%" KeyFieldName="NewsID" >
             <ClientSideEvents EndCallback="function(){ InitAction(); }" />
            <Columns>   
                  <dx:GridViewDataColumn Width="40" FixedStyle="Left">
                    <DataItemTemplate>
                        <a href="#" class="Edit" id="<%#Eval("NewsID") %>"><img src="/Content/images/grid/edit.png" /></a>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="false" ShowNewButton="false" ShowNewButtonInHeader="false" ButtonType="image" Caption=" " Width="40" FixedStyle="Left">
                </dx:GridViewCommandColumn>              
                <dx:GridViewDataColumn Caption ="Image" Width="110"> 
                    <DataItemTemplate>
                        <img src="/uploads/<%#Eval("ImgURL") %>?h=100" />
                    </DataItemTemplate>
                </dx:GridViewDataColumn>   
                <dx:GridViewDataComboBoxColumn FieldName="CategoryID">
                    <PropertiesComboBox DataSourceID="dsCategories" TextField="Caption" ValueField="DictionaryID">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataDateColumn FieldName="NewsDate" >
                </dx:GridViewDataDateColumn>
                <dx:GridViewBandColumn Caption="Title" Visible="false">
                    <Columns>
                <dx:GridViewDataTextColumn FieldName="TitleEN" Caption="English">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TitleKA" Caption="ქართული">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="TitleRU" Caption="Русский">
                </dx:GridViewDataTextColumn>
                    </Columns>
                </dx:GridViewBandColumn>
                 <dx:GridViewBandColumn Caption="Description" Visible="false">
                    <Columns>
                <dx:GridViewDataTextColumn FieldName="DescriptionEN" Caption="English">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="DescriptionKA" Caption="ქართული">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="DescriptionRU" Caption="Русский">
                </dx:GridViewDataTextColumn>
                         </Columns>
                </dx:GridViewBandColumn>
                <dx:GridViewBandColumn Caption="Full Text" Visible="false">
                    <Columns>
                <dx:GridViewDataTextColumn FieldName="FullTextEN" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="FullTextKA" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="FullTextRU" >
                </dx:GridViewDataTextColumn>
                         </Columns>
                </dx:GridViewBandColumn>
                <dx:GridViewDataTextColumn FieldName="SortVal" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="IsVisible" >
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataComboBoxColumn FieldName="GalleryID" >
                    <PropertiesComboBox DataSourceID="dsGalleries" TextField="Title" ValueField="RecordID">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataTextColumn FieldName="VideoURL" >
                </dx:GridViewDataTextColumn>           
            </Columns>
             <Templates>
                 <PreviewRow>
                     <b>Description EN</b>
                     <p><%#Eval("DescriptionEN") %></p>
                      <b>Description KA</b>
                     <p><%#Eval("DescriptionKA") %></p>
                      <b>Description RU</b>
                     <p><%#Eval("DescriptionRU") %></p>
                 </PreviewRow>
             </Templates>
             <Settings ShowPreview="true" />
        </dx:ASPxGridView>
        </div>
        <asp:ObjectDataSource ID="dsNews" runat="server" DeleteMethod="SP_News" SelectMethod="ListNews" TypeName="Core.CM.NewsRepository">
            <SelectParameters>
                <asp:Parameter Name="NewsID" Type="Int32" ConvertEmptyStringToNull="true" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="2" />
                <asp:Parameter Name="NewsID" Type="Int32" />
                <asp:Parameter Name="NewsDate" Type="DateTime" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionRU" Type="String" />
                <asp:Parameter Name="FullTextEN" Type="String" />
                <asp:Parameter Name="FullTextKA" Type="String" />
                <asp:Parameter Name="FullTextRU" Type="String" />
                <asp:Parameter Name="CategoryID" Type="Int32" />
                <asp:Parameter Name="SortVal" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
                <asp:Parameter Name="VideoURL" Type="String" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
            </DeleteParameters>           
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

            InitAction();

            $("#btnAddnew").click(function () {
                ShowPopupPage("/manager/popups/AddEditNews.aspx")
                return false;
            });

        });

        function InitAction() {

            $(".Edit").click(function () {
                ShowPopupPage("/manager/popups/AddEditNews.aspx?nid=" + $(this).prop("id"));
                return false;
            });
        }
    </script>
</asp:Content>
