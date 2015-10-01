<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="FileList.aspx.cs" Inherits="SMR.FileList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $(".file-groups").click(function () {
                $(this).parent().children(".file-item").toggleClass("hidden");
                return false;
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="internalContent">
                <h2  class="bottom-border">
                    <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
                </h2>
                <asp:Repeater runat="server" ID="rptFileGroups" OnItemDataBound="rptFileGroups_ItemDataBound">
                    <ItemTemplate>
                        <div>
                            <div class="file-groups fix-padding">
                                <a href="#"><i class="fa fa-bars"></i> <%#Eval("FileName") %></a>
                            </div>
                            <asp:Repeater runat="server" ID="rptFiles">
                                <ItemTemplate>
                                    <div class="file-item hidden">
                                        <a href="/Uploads/<%#Eval("URL") %>"><%#Eval("Description") %></a>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
