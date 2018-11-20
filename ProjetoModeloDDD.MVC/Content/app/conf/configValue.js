angular.module("cscPlanejamento").value("config", {
    baseUrl: function ($window) {
        
        var locale = $window.location.href;

        if (locale.indexOf('/Usuario') > -1) {
            locale = locale.split('/Usuario')[0].replace(/#\!\/$/, '');
        } else if (locale.indexOf('http://localhost:61831') > -1) {

            locale = 'http://localhost:61831';

        }else {
            locale = locale.split(/\/cscplanejamento/i)[0].replace(/#\!\/$/, '') + '/cscplanejamento';
        }
        
        while (locale.substring(locale.length - 1, locale.length) == '/') locale = locale.substring(0, locale.length-1);

        return locale + '/';
    }
});