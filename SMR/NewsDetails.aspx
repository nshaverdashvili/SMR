<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NewsDetails.aspx.cs" Inherits="SMR.NewsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="internalContent">
                <a href="#" class="mainImg">
                    <asp:Literal ID="ltrImgURL" runat="server"></asp:Literal>
                </a>
                <h2>
                    <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
                </h2>
                <span>
                    <asp:Literal ID="ltrDate" runat="server"></asp:Literal>
                </span>
                <p>
                    <asp:Literal ID="ltrFulltxt" runat="server"></asp:Literal>
                </p>
            </div>
        </div>
        <div id="fb-root"></div>
        <script>
            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s); js.id = id;
                js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1";
                fjs.parentNode.insertBefore(js, fjs);
            }(document, 'script', 'facebook-jssdk'));

        </script>

        <!-- Your share button code -->
        <div class="fb-share-button"
            data-href="http://www.your-domain.com/your-page.html"
            data-layout="button_count">
        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>

