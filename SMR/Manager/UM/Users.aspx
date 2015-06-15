<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="SMR.Manager.UM.Users"  Theme="DevEx"%>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <button class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
    </div>
    <div class"row">
        <dx:ASPxGridView ID="gridUsers" ClientInstanceName="gridUsers" runat="server" AutoGenerateColumns="False" DataSourceID="dsUsers" KeyFieldName="UserID" Width="100%"
            OnRowUpdating="gridUsers_RowUpdating">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="UserID" Visible="false" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="UserName">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Password"  >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Fname" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Lname" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Email">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="Gender" >
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataDateColumn FieldName="BirthDate" >
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataTextColumn FieldName="Phone" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Mobile" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Address" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="CountryID" visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Zip" visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="City" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Avatar" Visible="false" >
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="About" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="IsActive" >
                </dx:GridViewDataCheckColumn>
                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="False" ButtonType="Image" Caption=" ">
                    <CancelButton Visible="true">
                        <Image Url="~/Content/images/grid/cancel.png"></Image>
                    </CancelButton>
                    <UpdateButton Visible="true">
                        <Image Url="~/Content/images/grid/succsses.png"></Image>
                    </UpdateButton>                    
                    <NewButton Visible="true">
                        <Image Url="~/Content/images/grid/add.png"></Image>
                    </NewButton>
                    <EditButton Visible="true">
                        <Image Url="~/Content/images/grid/edit.png"></Image>
                    </EditButton>
                    <DeleteButton Visible="true">
                        <Image Url="~/Content/images/grid/delete.png"></Image>
                    </DeleteButton>
                </dx:GridViewCommandColumn>
            </Columns>
            <SettingsBehavior AllowFocusedRow="true" />
        </dx:ASPxGridView>
        <asp:ObjectDataSource ID="dsUsers" runat="server" DeleteMethod="SP_Users" InsertMethod="SP_Users" SelectMethod="ListUsers" TypeName="Core.UM.UserRepository" UpdateMethod="SP_Users">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="2"/>
                <asp:Parameter Name="UserID" Type="Int64" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Fname" Type="String" />
                <asp:Parameter Name="Lname" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Gender" Type="Boolean" />
                <asp:Parameter Name="BirthDate" Type="DateTime" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Mobile" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="CountryID" Type="Int32" />
                <asp:Parameter Name="Zip" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Avatar" Type="String" />
                <asp:Parameter Name="About" Type="String" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
            </DeleteParameters>
            
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="0"/>
                <asp:Parameter Name="UserID" Type="Int64" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Fname" Type="String" />
                <asp:Parameter Name="Lname" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Gender" Type="Boolean" />
                <asp:Parameter Name="BirthDate" Type="DateTime" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Mobile" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="CountryID" Type="Int32" />
                <asp:Parameter Name="Zip" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Avatar" Type="String" />
                <asp:Parameter Name="About" Type="String" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Byte" DefaultValue="1" />
                <asp:Parameter Name="UserID" Type="Int64" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Fname" Type="String" />
                <asp:Parameter Name="Lname" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Gender" Type="Boolean" />
                <asp:Parameter Name="BirthDate" Type="DateTime" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Mobile" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="CountryID" Type="Int32" />
                <asp:Parameter Name="Zip" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Avatar" Type="String" />
                <asp:Parameter Name="About" Type="String" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
            </UpdateParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {
            $("#btnAddnew").click(function () {
                gridUsers.AddNewRow();
            });
        });
    </script>
</asp:Content>
