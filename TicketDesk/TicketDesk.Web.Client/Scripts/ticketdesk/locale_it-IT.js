(function (window) {
    window.i18n = {
        unwatch : 'Segui',
        watch : 'Non seguire',
        formatWatch: function (isSubscribed) { return isSubscribed ? 'Non seguire' : 'Segui'; },
        formatWatchTitle: function (isSubscribed) { return (isSubscribed ? 'Non seguire' : 'Segui') + ' richiesta'; }
    };
})(window);