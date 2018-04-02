mergeInto(LibraryManager.library, {

  LoadAndInit: function () {
      window.fbAsyncInit = function() {
          FB.init({
              appId      : '744566825731864', 
              cookie     : true,
              xfbml      : true,
              version    : 'v2.10'
          });
      
      FB.AppEvents.logPageView();
          
      };

      (function(d, s, id){
         var js, fjs = d.getElementsByTagName(s)[0];
         if (d.getElementById(id)) {return;}
         js = d.createElement(s); js.id = id;
         js.src = "https://connect.facebook.net/en_US/sdk.js";
         fjs.parentNode.insertBefore(js, fjs);
      }(document, 'script', 'facebook-jssdk'));
  },

  ClickShare: function () {
    FB.ui({
        method: 'share',
        display: 'popup',
        href: 'https://developers.facebook.com/docs/',
    }, function(response){});
  },

});