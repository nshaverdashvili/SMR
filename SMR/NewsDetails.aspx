<%@ Page Title="" Language="C#" MasterPageFile="~/CMMaster.Master" AutoEventWireup="true" CodeBehind="NewsDetails.aspx.cs" Inherits="SMR.NewsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--FB Button-->
    <meta property="og:url" content="<%=ogUrl %>" />
    <meta property="og:type" content="article" />
    <meta property="og:title" content="<%=ogTitle %>" />
    <meta property="og:description" content="<%=ogDescription %>" />
    <meta property="og:image" content="<%=ogImg %>" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyPlaceHolder" runat="server">
    <div class="container-fluid main">
        <div class="row">
            <div class="internalContent">

                <asp:Literal ID="ltrImgURL" runat="server"></asp:Literal>

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
        <div class="row">
            <div id="fb-root"></div>
            <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.5&appId=1005613462836517";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
            <div class="fb-share-button" data-href="<%=ogUrl %>" data-layout="button_count"></div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Repeater runat ="server" ID="rptNewsGallery" ItemType="Core.Files.Files">
                <ItemTemplate>
                    <a href="/Uploads/<%#Item.URL %>" class="fancybox" data-fancybox-group="NewsGallery"><img src="/Uploads/<%#Item.URL %>?w=140" class="img-thumbnail" /></a>
                </ItemTemplate>
            </asp:Repeater>
            
            
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsPlaceHolder" runat="server">
</asp:Content>

