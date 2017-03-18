

var _PageWidth = 0,//页面宽
    _PageHeight = 0,//页面高
    ContenIframeH = 0;


// 方式二
$(function () {
    PageDivSet();
});



//页面宽高
function PageDivSet() {
    
    _PageWidth = parseInt($(window).width());//页面宽
    _PageHeight = parseInt($(window).height());////页面高
    ContenIframeH = _PageHeight - parseInt($('body').css('paddingTop'));
    $(".page-content").height(ContenIframeH)
    $("#MainIframe").height(ContenIframeH - 106);
}


