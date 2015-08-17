<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Permissions.aspx.cs" Inherits="SMR.Manager.UM.Permissions" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
   <div class="row"> 
        <div class="col-xs-12" style="margin:20px 0;">
            <button class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
        <dx:ASPxTreeList ID="tlPermissions" ClientInstanceName="tlPermissions" runat="server" AutoGenerateColumns="False" DataSourceID="dsPermissions"
            KeyFieldName="PermissionID" ParentFieldName="ParentID">
            <Columns>
                <dx:TreeListTextColumn FieldName="PermissionID" Visible="false">
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="ParentID" Visible="false">
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="CaptionEN" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="CaptionKA" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="CaptionRU" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="PageName">
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="CodeName" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="SortVal" >
                </dx:TreeListTextColumn>
                <dx:TreeListCheckColumn FieldName="IsVisible">
                </dx:TreeListCheckColumn>
                <dx:TreeListTextColumn FieldName="PermissionsCode" >
                    <EditCellTemplate></EditCellTemplate>
                </dx:TreeListTextColumn>
                <dx:TreeListCommandColumn ButtonType="Image" Caption=" ">
                    <CancelButton Visible="true">
                        <Image Url="~/Content/images/grid/cancel.png"></Image>
                    </CancelButton>
                    <UpdateButton Visible="true">
                        <Image Url="~/Content/images/grid/succsses.png"></Image>
                    </UpdateButton>
                    <NewButton Visible="True">
                        <Image Url="~/Content/images/grid/add.png"></Image>
                    </NewButton>
                    <EditButton Visible="True">
                        <Image Url="~/Content/images/grid/edit.png"></Image>
                    </EditButton>
                    <DeleteButton Visible="True">
                        <Image Url="~/Content/images/grid/delete.png"></Image>
                    </DeleteButton>
                </dx:TreeListCommandColumn>
            </Columns>
            <SettingsBehavior AllowFocusedNode="true" />
        </dx:ASPxTreeList>
        </div>
    </div>
    <asp:ObjectDataSource ID="dsPermissions" runat="server" DeleteMethod="SP_Permissions" InsertMethod="SP_Permissions" SelectMethod="ListPermissions" TypeName="Core.UM.PermissionsRepository" UpdateMethod="SP_Permissions">
        <DeleteParameters>
            <asp:Parameter Name="iud" Type="Byte" DefaultValue="2"/>
            <asp:Parameter Name="PermissionID" Type="Int32" />
            <asp:Parameter Name="ParentID" Type="Int32" />
            <asp:Parameter Name="CaptionEN" Type="String" />
            <asp:Parameter Name="CaptionKA" Type="String" />
            <asp:Parameter Name="CaptionRU" Type="String" />
            <asp:Parameter Name="PageName" Type="String" />
            <asp:Parameter Name="CodeName" Type="String" />
            <asp:Parameter Name="SortVal" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="iud" Type="Byte" DefaultValue="0" />
            <asp:Parameter Name="PermissionID" Type="Int32" />
            <asp:Parameter Name="ParentID" Type="Int32" />
            <asp:Parameter Name="CaptionEN" Type="String" />
            <asp:Parameter Name="CaptionKA" Type="String" />
            <asp:Parameter Name="CaptionRU" Type="String" />
            <asp:Parameter Name="PageName" Type="String" />
            <asp:Parameter Name="CodeName" Type="String" />
            <asp:Parameter Name="SortVal" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="iud" Type="Byte" DefaultValue="1" />
            <asp:Parameter Name="PermissionID" Type="Int32" />
            <asp:Parameter Name="ParentID" Type="Int32" />
            <asp:Parameter Name="CaptionEN" Type="String" />
            <asp:Parameter Name="CaptionKA" Type="String" />
            <asp:Parameter Name="CaptionRU" Type="String" />
            <asp:Parameter Name="PageName" Type="String" />
            <asp:Parameter Name="CodeName" Type="String" />
            <asp:Parameter Name="SortVal" Type="Int32" />
            <asp:Parameter Name="IsVisible" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {

            $("#btnAddnew").click(function () {
                tlPermissions.StartEditNewNode();
                return false;
            });

        });
    </script>
</asp:Content>
