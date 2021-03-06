﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Files.aspx.cs" Inherits="SMR.Manager.Files.Files" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal ID="litHeader" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row"> 
        <div class="col-xs-12" style="margin:20px 0;">
            <button class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
        <dx:ASPxGridView ID="gridFiles" ClientInstanceName="gridFiles" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="dsFiles"
            OnRowDeleting="gridFiles_RowDeleting"
            KeyFieldName="FileID">
            <ClientSideEvents EndCallback="function(){ InitAction(); }" />
            <Columns>                
                <dx:GridViewDataTextColumn FieldName="FileName" width="350">
                    <DataItemTemplate>
                       En: <%#Eval("FileNameEn") %><br />
                       Ka: <%#Eval("FileNameKa") %><br />
                       Ru: <%#Eval("FileNameRu") %>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>

                <dx:GridViewBandColumn Caption="Description">
                    <Columns>
                <dx:GridViewDataTextColumn FieldName="DescriptionEN" Caption="English" width="350">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="DescriptionKA" Caption="ქართული" width="350">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="DescriptionRU" Caption="Русский" width="350">
                </dx:GridViewDataTextColumn>
                    </Columns>
                </dx:GridViewBandColumn>
                <dx:GridViewDataTextColumn FieldName="URL" width="150">
                    <DataItemTemplate>
                       En: <%#Eval("UrlEn") %><br />
                       Ka: <%#Eval("UrlKa") %><br />
                       Ru: <%#Eval("UrlRu") %>
                    </DataItemTemplate>
                </dx:GridViewDataTextColumn>
                 <dx:GridViewDataComboBoxColumn FieldName="TypeID">
                    <PropertiesComboBox DataSourceID="dsTypes" TextField="Caption" ValueField="DictionaryID" EnableSynchronization="False">
                    </PropertiesComboBox>
                </dx:GridViewDataComboBoxColumn>
                <dx:GridViewDataColumn Caption="  " Width="40px">
                    <DataItemTemplate>
                        <a href="#" class="Edit" id="<%#Eval("FileID") %>"><img src="/Content/images/grid/edit.png" /></a>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
               <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="false" ShowNewButton="false" ShowNewButtonInHeader="false" ButtonType="Image" Caption=" " Width="40px" >
               </dx:GridViewCommandColumn>
            </Columns>
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsFiles" runat="server" DeleteMethod="SP_Files" SelectMethod="ListFiles" TypeName="Core.Files.FilesRepository">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32"  DefaultValue="2"/>
                <asp:Parameter Name="FileID" Type="Int32" />
                <asp:Parameter Name="FileNameKa" Type="String" />
                <asp:Parameter Name="FileNameEn" Type="String" />
                <asp:Parameter Name="FileNameRu" Type="String" />
                <asp:Parameter Name="DescriptionEN" Type="String" />
                <asp:Parameter Name="DescriptionKA" Type="String" />
                <asp:Parameter Name="DescriptionRU" Type="String" />
                <asp:Parameter Name="URL" Type="String" />
                <asp:Parameter Name="URLKa" Type="String" />
                <asp:Parameter Name="URLRu" Type="String" />
                <asp:Parameter Name="TypeID" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:Parameter Name="FileID" Type="Int32" ConvertEmptyStringToNull="true" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="dsTypes" runat="server" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="Lvl" Type="Int32" />
                <asp:Parameter DefaultValue="1" Name="Code" Type="Int32" />
                <asp:Parameter DefaultValue="" Name="IsVisible" Type="Boolean" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {

            InitAction();

            $("#btnAddnew").click(function () {
                ShowPopupPage("/manager/popups/addeditfile.aspx")
                return false;
            });

        });

        function InitAction() {

            $(".Edit").click(function () {
                ShowPopupPage("/manager/popups/addeditfile.aspx?fid=" + $(this).prop("id"));
                return false;
            });
        }
    </script>
</asp:Content>
