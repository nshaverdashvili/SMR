<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/AdminPage.Master" AutoEventWireup="true" CodeBehind="Dictionaries.aspx.cs" Inherits="SMR.Tools.Dictionaries" Theme="DevEx"%>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="row">
        <button type="button" class="btn btn-success" id="btnAddnew"><%=Core.Properties.Resources.CreateNew %></button>
    </div>
    <div class="row">
        <dx:ASPxTreeList ID="tlDictionaries" ClientInstanceName="tlDictionaries" runat="server" AutoGenerateColumns="False" 
            DataSourceID="dsDictionaries" KeyFieldName="DictionaryID" ParentFieldName="ParentID">
            <Columns>
                <dx:TreeListTextColumn FieldName="DictionaryCode">
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="Caption" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="Caption1" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="CodeVal" >
                </dx:TreeListTextColumn>
                <dx:TreeListTextColumn FieldName="StringCode" >
                </dx:TreeListTextColumn>
                <dx:TreeListCheckColumn FieldName="DefVal" >
                </dx:TreeListCheckColumn>
                <dx:TreeListCheckColumn FieldName="Visible" >
                </dx:TreeListCheckColumn>
                <dx:TreeListTextColumn FieldName="SortVal">
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
            <SettingsBehavior AllowFocusedNode="true"  AllowDragDrop="true" />

            <SettingsEditing AllowNodeDragDrop="True" />

        </dx:ASPxTreeList>
        <asp:ObjectDataSource ID="dsDictionaries" runat="server" DeleteMethod="SP_Dictionary" InsertMethod="SP_Dictionary" SelectMethod="ListDictionary" TypeName="Core.Tools.DictionariesRepository" UpdateMethod="SP_Dictionary">
            <DeleteParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="2" />
                <asp:Parameter Name="DictionaryID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Caption1" Type="String" />
                <asp:Parameter Name="CodeVal" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="Level" Type="Int16" />
                <asp:Parameter Name="Hierarchy" Type="String" />
                <asp:Parameter Name="StringCode" Type="String" />
                <asp:Parameter Name="DictionaryCode" Type="Int32" />
                <asp:Parameter Name="DefVal" Type="Boolean" />
                <asp:Parameter Name="Visible" Type="Boolean" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="0" />
                <asp:Parameter Name="DictionaryID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Caption1" Type="String" />
                <asp:Parameter Name="CodeVal" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="Level" Type="Int16" />
                <asp:Parameter Name="Hierarchy" Type="String" />
                <asp:Parameter Name="StringCode" Type="String" />
                <asp:Parameter Name="DictionaryCode" Type="Int32" />
                <asp:Parameter Name="DefVal" Type="Boolean" />
                <asp:Parameter Name="Visible" Type="Boolean" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </InsertParameters>            
            <SelectParameters>
                <asp:Parameter Name="Lvl" Type="Int32" />
                <asp:Parameter Name="Code" Type="Int32" />
                <asp:Parameter Name="IsVisible" Type="Boolean" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="iud" Type="Int32" DefaultValue="1"/>
                <asp:Parameter Name="DictionaryID" Type="Int32" />
                <asp:Parameter Name="Caption" Type="String" />
                <asp:Parameter Name="Caption1" Type="String" />
                <asp:Parameter Name="CodeVal" Type="Int32" />
                <asp:Parameter Name="ParentID" Type="Int32" />
                <asp:Parameter Name="Level" Type="Int16" />
                <asp:Parameter Name="Hierarchy" Type="String" />
                <asp:Parameter Name="StringCode" Type="String" />
                <asp:Parameter Name="DictionaryCode" Type="Int32" />
                <asp:Parameter Name="DefVal" Type="Boolean" />
                <asp:Parameter Name="Visible" Type="Boolean" />
                <asp:Parameter Name="SortVal" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
    <script>
        $(function () {

            $("#btnAddnew").click(function () {
                tlDictionaries.StartEditNewNode();
                return false;
            });

        });
    </script>
</asp:Content>
