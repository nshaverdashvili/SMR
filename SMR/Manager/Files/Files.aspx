<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Files.aspx.cs" Inherits="SMR.Manager.Files.Files" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row"> 
        <button class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
    </div>
    <div class="row">
        <dx:ASPxGridView ID="gridFiles" ClientInstanceName="gridFiles" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="dsFiles"
            KeyFieldName="FileID">
            <Columns>                
                <dx:GridViewDataTextColumn FieldName="FileName" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Description" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="URL" >
                    <EditItemTemplate>
                        <dx:ASPxUploadControl ID="UploadFile" ClientInstanceName="FileUploader" runat="server" UploadMode="Auto" Width="180px" 
                            OnFilesUploadComplete="UploadFile_FilesUploadComplete">
                            <ValidationSettings MaxFileSize="4000000" ></ValidationSettings>
                        </dx:ASPxUploadControl>
                        <button onclick="OnUploadFile()">Upload</button>
                    </EditItemTemplate>
                </dx:GridViewDataTextColumn>
               <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="true" ShowNewButtonInHeader="false" ButtonType="Image" Caption=" " >
            </dx:GridViewCommandColumn>
                <dx:GridViewDataComboBoxColumn FieldName="TypeID" VisibleIndex="3">
                    <PropertiesComboBox DataSourceID="dsTypes" TextField="Caption" ValueField="DictionaryID">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
            </Columns>
            
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsFiles" runat="server" DeleteMethod="SP_Files" InsertMethod="SP_Files" SelectMethod="ListFiles" TypeName="Core.Files.FilesRepository" UpdateMethod="SP_Files">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32"  DefaultValue="2"/>
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="FileName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="TypeID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="0" />
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="FileName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="TypeID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="1"/>
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="FileName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="TypeID" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsTypes" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
                <asp:Parameter DefaultValue="1" Name="Code" Type="Int32" />
                <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {
            $("#btnAddnew").click(function () {
                gridFiles.AddNewRow();
                return false;
            });
        });

        function OnUploadFile() {
            FileUploader.UploadFile();
            return false;
        }
    </script>
</asp:Content>
