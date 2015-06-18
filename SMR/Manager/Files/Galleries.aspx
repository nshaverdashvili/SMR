<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Galleries.aspx.cs" Inherits="SMR.Manager.Files.Galleries" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <button class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
    </div>
    <div class="row">
        <dx:ASPxGridView ID="gridGallery" ClientInstanceName="gridGallery" runat="server" AutoGenerateColumns="False" DataSourceID="dsGallery" Width="100%" KeyFieldName="RecordID">
            <Columns>                
                <dx:GridViewDataTextColumn FieldName="RecordID" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Title" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Description" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="LangID" Visible="false">
                </dx:GridViewDataTextColumn>       
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="true" ShowNewButtonInHeader="false" ButtonType="image" Caption=" ">
                    
                </dx:GridViewCommandColumn>        
            </Columns>

        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsGallery" runat="server" DeleteMethod="SP_Galleries" InsertMethod="SP_Galleries" SelectMethod="ListGallery" TypeName="Core.Files.GalleryRepository" UpdateMethod="SP_Galleries">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="2"/>
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="0"/>
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="1"/>
                <asp:Parameter Name="RecordID" Type="Int32" />
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="LangID" Type="Int32" />
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
