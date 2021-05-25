var content = document.getElementById("content");
var sideBar = document.getElementById("aside");
var logo = document.getElementById("logo");

var w = document.documentElement.clientWidth;

window.addEventListener("resize", () => {
    if (w > 576) {

        sideBar.style.display = "block";
        logo.style.display = "none";
        
    }
});
function toggle() {
    if (sideBar.style.display == "block") {
        sideBar.style.display = "none";
        logo.style.display = "block";
        content.style.width = "100%";
    }
    else {
        sideBar.style.display = "block";
        logo.style.display = "none";
        sideBar.style.zIndex = 100;
    }

}