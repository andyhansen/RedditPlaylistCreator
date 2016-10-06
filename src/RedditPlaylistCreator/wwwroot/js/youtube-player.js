var YouTubePlayer = (function (youtubeApi) {
    var index = 0,
        youtubeIds = [],
        player = null;

    function onPlayerReady(event) {
        event.target.loadVideoById(youtubeIds[index]);
    }

    function onPlayerStateChange(event) {
        if (event.data == youtubeApi.PlayerState.ENDED) {
            index++;
            if (index < youtubeIds.length) {
                player.loadVideoById(youtubeIds[index]);
            }
        }
    }

    return {
        init: function (playerId, youtubeIdsParam) {
            youtubeIds = youtubeIdsParam;
            player = new youtubeApi.Player(playerId, {
                height: 390,
                width: 640,
                events: {
                    'onReady': onPlayerReady,
                    'onStateChange': onPlayerStateChange
                }
            });


        }
    }

});