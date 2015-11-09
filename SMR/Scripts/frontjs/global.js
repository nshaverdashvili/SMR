$(function () {
    $(".ical").datepicker();
    $(".ical").prop("readonly", true);

    $("a[data-showpopup='true']").click(function () {
        var url = $(this).attr("href");
        var width = $(this).attr("data-width");
        var height = $(this).data("data-height");
        ShowPopupImg(url, width, height);
        return false;
    });
});
function ShowPopupImg(url) {
    $.fancybox.open({
        href: url       
    });
}


function ShowPopupPage(url, width, height) {
    $.fancybox.open({
        href: url,
        type: 'iframe',
        width: width,
        height: height
    });
}
function ClosePopupPage() {
    $.fancybox.close();
}

function gup(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}