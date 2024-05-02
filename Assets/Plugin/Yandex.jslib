mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log("Hello world");
  },

  Show: function (){
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          console.log("включение рекламы");
          // some action after close
        },
        onError: function(error) {
          // some action on error
        }
      }
    })
  },
});