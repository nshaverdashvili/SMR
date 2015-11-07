<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Galleries.aspx.cs" Inherits="SMR.Manager.Files.Galleries" Theme="DevEx" %>

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
            <dx:ASPxGridView ID="gridGallery" ClientInstanceName="gridGallery" runat="server" AutoGenerateColumns="False" DataSourceID="dsGallery" Width="100%" KeyFieldName="RecordID">
                <Columns>
                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="false" ShowNewButtonInHeader="false" ButtonType="image" Caption=" " Width="60">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="RecordID">
                        <EditItemTemplate>
                            <%#Eval("RecordID") %>
                        </EditItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewBandColumn Caption="Title">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="TitleEN" Caption="English">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="TitleKA" Caption="ქართული">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="TitleRU" Caption="Русский">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:GridViewBandColumn>
                    <dx:GridViewBandColumn Caption="Description">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="DescriptionEN" Caption="English">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DescriptionKA" Caption="ქართული">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DescriptionRU" Caption="Русский">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:GridViewBandColumn>
                </Columns>
                <Templates>
                    <DetailRow>
                        
                        <dx:ASPxGridView runat="server" ID="GridGalleryFiles" ClientInstanceName="gridGalleryFiles" DataSourceID="dsGalleryFiles" KeyFieldName="RecordID"
                            OnRowInserting="GridGalleryFiles_RowInserting" 
                            OnRowUpdated="GridGalleryFiles_RowUpdated"
                            OnBeforePerformDataSelect="GridGalleryFiles_BeforePerformDataSelect" >                            
                            <Columns>
                                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="false" ShowNewButtonInHeader="True" ButtonType="image" Caption=" " Width="60">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="URL" Width="120">
                                    <EditItemTemplate></EditItemTemplate>
                                    <DataItemTemplate>
                                        <img src="/Uploads/<%#Eval("URL") %>?h=100&w=150&mode=stretch" height="100"/>
                                    </DataItemTemplate>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn FieldName="FileID" Width="200" Caption="File Name">
                                    <PropertiesComboBox DataSourceID="dsFiles" ValueField="FileID" TextFormatString="{0}">
                                        <Columns>
                                            <dx:ListBoxColumn FieldName="FileName" />
                                            <dx:ListBoxColumn FieldName="Description" />
                                        </Columns>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataCheckColumn FieldName="IsDefault" Width="100">
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn FieldName="Description" Width="250">
                                    <EditItemTemplate></EditItemTemplate>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn FieldName="TypeID" Caption="File Type" Width="200">
                                    <EditItemTemplate></EditItemTemplate>
                                    <PropertiesComboBox DataSourceID="dsFileType" TextField="Caption" ValueField="DictionaryID">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                
                                <dx:GridViewDataTextColumn FieldName="SortVal" Caption="SortVal" Width="50">                                                                       
                                </dx:GridViewDataTextColumn>

                            </Columns>
                            <SettingsEditing Mode="Inline"></SettingsEditing>
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="true" />

            </dx:ASPxGridView>
        </div>

        <asp:ObjectDataSource ID="dsFiles" runat="server" TypeName="Core.Files.FilesRepository" SelectMethod="ListFiles">
            <SelectParameters>
                <asp:Parameter Name="FileID" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>


        <asp:ObjectDataSource ID="dsGalleryFiles" runat="server" TypeName="Core.Files.FilesRepository" SelectMethod="ListGalleryFiles" DeleteMethod="SP_GalleryFiles" InsertMethod="SP_GalleryFiles" UpdateMethod="SP_GalleryFiles">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="2" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="IsDefault" Type="Boolean" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="0" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="IsDefault" Type="Boolean" DefaultValue="false" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:Parameter Name="GalleryID" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="1" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="GalleryID" Type="Int32" />
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="IsDefault" Type="Boolean" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsFileType" runat="server" TypeName="Core.Tools.DictionariesRepository" SelectMethod="ListDictionary">
            <SelectParameters>
                <asp:Parameter Name="Lvl" Type="Int32" DefaultValue="1" />
                <asp:Parameter Name="Code" Type="Int32" DefaultValue="1" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsGallery" runat="server" DeleteMethod="SP_Galleries" InsertMethod="SP_Galleries" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository" UpdateMethod="SP_Galleries">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="2" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionRU" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="0" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionRU" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="1" />
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="TitleEN" Type="String" />
                <asp:Parameter Name="TitleKA" Type="String" />
                <asp:Parameter Name="TitleRU" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionRU" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {
            $("#btnAddnew").click(function () {
                gridGallery.AddNewRow();
                return false;
            });

          
        });
    </script>
</asp:Content>
