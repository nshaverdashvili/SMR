﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Galleries.aspx.cs" Inherits="SMR.Manager.Files.Galleries" Theme="DevEx" %>

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
                    <dx:GridViewDataTextColumn FieldName="RecordID" Visible="false">
                    </dx:GridViewDataTextColumn>
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
                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="false" ShowNewButtonInHeader="false" ButtonType="image" Caption=" " Width="60">
                    </dx:GridViewCommandColumn>
                </Columns>

            </dx:ASPxGridView>
        </div>

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
