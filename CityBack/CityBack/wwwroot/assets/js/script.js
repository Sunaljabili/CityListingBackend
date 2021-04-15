$(document).ready(function(){
    "use strict";

    //Search

    
    $(document).on("keyup", "#input_search", function () {

        let search = $(this).val().trim();
        $("#searchList div").slice(1).remove();
        if (search.length != 0) {

            $.ajax({
                url: "/Blog/Search?search=" + search,
                type: "Get",
                success: function (res) {
                    $("#searchList").append(res)
                }

            })
        }
    })
// NAVBAR STICKY START
$(window).scroll(function(){
  if($("html").scrollTop() >300){
    $("header").addClass("is-sticky");
  }else{
    $("header").removeClass("is-sticky");
  }
})

// NAVBAR STICKY END



// TESTIMONIAL SLICK PLUGIN START
    if($(".one-time").length){
        $('.one-time').slick({
            slidesToShow: 1,
            adaptiveHeight: true,
            prevArrow: '<i class="fal fa-chevron-left"></i>',
            nextArrow: '<i class="fal fa-chevron-right"></i>',
          });
    }
// TESTIMONIAL SLICK PLUGIN END
      
// TO-TOP BUTTON START
$(window).scroll(function(){

  if($(this).scrollTop() > 300){
     $(".to-top").fadeIn();
  }else{
    $(".to-top").fadeOut();
  }
});

$(".to-top").click(function(){
  $("html,body").animate({scrollTop:0},"slow")
});
// TO-TOP BUTTON END

// Spinner LOAD  START

$(window).on("load",function(){
  $(".load1").fadeOut(1000)
  $("header").fadeIn(1000)
  $("main").fadeIn(1000)
  $("footer").fadeIn(1000)
})
// Spinner LOAD  END



    $("#mc-embedded-subscribe").on("click", function () {
        let email = $("#mce-EMAIL").val()
        $.ajax({
            url: "/blog/subscribe",
            data: {
                email: email,
            },
            Type: 'Get',
            success: function (r) {
                alert(r)
            }
        })
    })
});