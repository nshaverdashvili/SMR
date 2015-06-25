function ShowPopupPage(url, width, height) {
    $.fancybox.open({
        href: url,
        type: 'iframe'
    });
}
function ClosePopupPage() {
    $.fancybox.close();
}