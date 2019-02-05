$(window).scroll(function () {
   if ($(window).scrollTop() > 0) {
        $('.fadeInBlock').stop().fadeTo("slow", 0);
        console.log('p')
    } else {
        $('.fadeInBlock').stop().fadeTo("fast", 1);
        console.log(box1Top)
    }
});