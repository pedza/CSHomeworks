$(document).ready(function () {


    //navbar active links
    $(".navbar-nav").find('[href ="' + window.location.pathname + '"]').parent().addClass("active");
    console.log($(".navbar-nav").find('[href ="' + window.location.pathname + '"]').parent().addClass("active"))

    $('.carousel').carousel({
        interval: 1800
    })
})