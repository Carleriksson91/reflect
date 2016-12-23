/*!
 * Start Bootstrap - Agnecy Bootstrap Theme (http://startbootstrap.com)
 * Code licensed under the Apache License v2.0.
 * For details, see http://www.apache.org/licenses/LICENSE-2.0.
 */

// jQuery for page scrolling feature - requires jQuery Easing plugin
$(function () {
    hideSections();
    $('a.page-scroll').bind('click', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });

    $("section").on("scroll", function (e) {
        e.preventDefault();
        console.log("hdioada");
        var currentscroll = $(window).scrollTop();
        var $visibleSections = $("section:visible");
        $visibleSections.each(function (i) {
            if (currentscroll >= $(this).offset().top + $(this).outerHeight() - window.innerHeight) {
                var $currentTarget = $(this);
                if ($currentTarget.next("section").length) {
                    $currentTarget.next("section").fadeTo(1000, 0.8, function () {
                        $currentTarget.fadeTo(100, 0.5, "linear");
                    });
                }
            }
            i++;
        });

    });
});

function hideSections() {
    var $sections = $("body").find("section");
    $sections.each(function (i) {
        if (i > 0) {
            $(this).css('opacity', 0);
        }
    });
}
// Highlight the top nav as scrolling occurs
$('body').scrollspy({
    target: '.navbar-fixed-top'
});

// Closes the Responsive Menu on Menu Item Click
$('.navbar-collapse ul li a').click(function () {
    $('.navbar-toggle:visible').click();
});