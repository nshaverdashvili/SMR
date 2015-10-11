<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="FilePage.aspx.cs" Inherits="SMR.FilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $(".item > a").click(function () {
                $(this).parent().children(".file").slideToggle("slow");
                return false;
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row files internalContent ">
            <h2>
                <asp:Literal runat="server" ID="litTitle">
                </asp:Literal>
            </h2>
            <asp:Repeater runat="server" ID="rptItem">
                <ItemTemplate>
                    <div class="item">
                        <a href="#">სტრუქტურა და ფუნქციების აღწერა</a>
                        <div class="file" style="display: none;">
                            <a href="#">შერიგებისა და სამოქალაქო თანასწორობის საკითხებში საქართველოს სახელმწიფო მინისტრის აპარატის დებულება (განახლებადია ცვლილებების შემთხვევაში)</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>
