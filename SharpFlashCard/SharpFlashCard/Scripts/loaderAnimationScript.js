$(document).on('ready', function () {
    $("#element").introLoader({
        animation: {
            name: 'lettersLoader',
            options: {
                ease: "easeInOutCirc",
                style: 'light',
                delayBefore: 500,
                delayAfter: 0,
                exitTime: 300,
                loaderText: 'Page ready!',
                lettersDelayTime: 0
            }
        }
    });
});