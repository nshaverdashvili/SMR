<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="SMR.Manager.UM.Roles" Theme="DevEx" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
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
        <dx:ASPxGridView ID="gridRoles" ClientInstanceName="gridRoles" runat="server" AutoGenerateColumns="False" DataSourceID="dsRoles" Width="100%"
            KeyFieldName="RoleID">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="RoleID" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Caption"  >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Code" >
                </dx:GridViewDataTextColumn>                
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButton="true" ShowNewButtonInHeader="false" ButtonType="Image" Caption=" " >                    
                    </dx:GridViewCommandColumn>
            </Columns>
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsRoles" runat="server" DeleteMethod="SP_Roles" InsertMethod="SP_Roles" SelectMethod="ListRoles" TypeName="Core.UM.RolesRepository" UpdateMethod="SP_Roles">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="2"/>
                <asp:Parameter Name="RoleID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Code" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Byte"  DefaultValue="0"/>
                <asp:Parameter Name="RoleID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Code" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="1" />
                <asp:Parameter Name="RoleID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Code" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {
            $("#btnAddnew").click(function () {
                gridRoles.AddNewRow();
            });

        });
    </script>
</asp:Content>
