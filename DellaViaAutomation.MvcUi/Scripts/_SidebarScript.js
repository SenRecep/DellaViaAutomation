var sidebarstatus = true;
function SidebarOpenClose() {
    if (sidebarstatus) {
        sidebarstatus = false;
        $("#sidebar-controller-button").text("☰").addClass("sidebar-controller-button-closed");
        $(".sidebar").width(0);
    }
    else {
        sidebarstatus = true;
        $("#sidebar-controller-button").text("✘").removeClass("sidebar-controller-button-closed");
        $(".sidebar").width(240);
    }
}

$(function () {
    $("#sidebar-controller-button").click(function () {
        SidebarOpenClose();
    })
});
setTimeout(SidebarOpenClose, 1500);


