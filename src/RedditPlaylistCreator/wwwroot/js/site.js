var YouTubePlayer=function(e){function t(e){e.target.loadVideoById(o[a]),e.target.pauseVideo()}function n(t){t.data==e.PlayerState.ENDED&&(a++,a<o.length&&i.loadVideoById(o[a]))}var a=0,o=[],i=null;return{init:function(a,d){o=d,i=new e.Player(a,{height:390,width:640,events:{onReady:t,onStateChange:n}})}}};