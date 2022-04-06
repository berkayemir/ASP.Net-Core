// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//$(document).ready(function () {
	
//	$('ul.navbar-nav > li > a')
//		.click(function (e) {
//			$('ul.navbar-nav > li > a')
//				.removeClass('active');
//			$(this).addClass('active');
//		});


//});

$(document).ready(function () {
    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname) {
            $(this).addClass("active")
        }
    })

})