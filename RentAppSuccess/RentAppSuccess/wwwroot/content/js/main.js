jQuery(document).ready(function($) {

	'use strict';

        $(function() {
  
          // Vars
          var modBtn  = $('#modBtn'),
              modal   = $('#modal'),
              close   = modal.find('.close-btn img'),
              modContent = modal.find('.modal-content');
          
          // open modal when click on open modal button 
          modBtn.on('click', function() {
            modal.css('display', 'block');
            modContent.removeClass('modal-animated-out').addClass('modal-animated-in');
          });
          
          // close modal when click on close button or somewhere out the modal content 
          $(document).on('click', function(e) {
            var target = $(e.target);
            if(target.is(modal) || target.is(close)) {
              modContent.removeClass('modal-animated-in').addClass('modal-animated-out').delay(300).queue(function(next) {
                modal.css('display', 'none');
                next();
              });
            }
          });
          
        });

        // on click event on all anchors with a class of scrollTo
        $('a.scrollTo').on('click', function(){
          
          // data-scrollTo = section scrolling to name
          var scrollTo = $(this).attr('data-scrollTo');
          
          
          // toggle active class on and off. added 1/24/17
          $( "a.scrollTo" ).each(function() {
            if(scrollTo == $(this).attr('data-scrollTo')){
              $(this).addClass('active');
            }else{
              $(this).removeClass('active');
            }
          });
          
          
          // animate and scroll to the sectin 
          $('body, html').animate({
            
            // the magic - scroll to section
            "scrollTop": $('#'+scrollTo).offset().top
          }, 1000 );
          return false;
          
        })
 

        $(".menu-icon").click(function() {
          $(this).toggleClass("active");
          $(".overlay-menu").toggleClass("open");
        });

});
async function postEmail () {
  var name = document.getElementById("name").value;
  var email = document.getElementById("email").value;
  var question = document.getElementById("message").value;
  var url = "http://localhost:56869/api/email/post";
  //var customer = {Contact_Name :name,Contact_Email:email,Contact_Question:question};
  var customer = {Contact_Name :"Scott",Contact_Email:"HP",Contact_Question:"hej"};
  
  console.log(customer);
  await fetch(url,{
    method: 'POST',
    mode: "no-cors",
    body: JSON.stringify({Contact_Name :"Scott",Contact_Email:"HP",Contact_Question:"hej"}),
    headers: {
      'Accept': 'application/json, text/plain, */*',
      'Content-Type': 'application/json; charset=UTF-8'
    }
    
    }).then(function (data) {
       console.log(data)
   })
  };
 

