$(document).on('ready', function() {
    $("#element").introLoader({
        animation: {
            name: 'lettersLoader',
            options: {
                ease: "easeInOutCirc",
                style: 'light',
                delayBefore: 500,
                delayAfter: 0,
                exitTime: 15,
                loaderText: 'Page is almost ready! ... Shhh...Jay....Im trying to think',
                lettersDelayTime: 0
            }
        }
    });
});

