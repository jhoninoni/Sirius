angular.module("cscComponentes", []);
angular.module("cscComponentes").
    directive('bsPopover', ['$parse', function ($parse) {
        
    var fn_link = function (scope, element, attrs) {

        var confirm = $parse(attrs.bsPopover);

        element.confirmation({
                html: 'true',
                onConfirm: function ()
                {
                    confirm(scope);
                }        });
    };

    return {

        link:fn_link
    }


}]);

angular.module("cscComponentes").
    directive('datePicker', function () {
    return function (scope, element, attrs) {
        element.datepicker({ language: 'pt-BR' });
        if (attrs.datePicker.length >0 ) element.datepicker('update', attrs.datePicker);
        
    };
    });

angular.module("cscComponentes").
    directive('modalView', function () {
        return function (scope, element, attrs) {
            element.confirmation();
        };
    });

angular.module('cscComponentes').
    config(function ($httpProvider) {        
        $httpProvider.interceptors.push('loadingInterceptor');
        $httpProvider.interceptors.push('noCacheInterceptor');
    });

angular.module('cscComponentes').
    factory('loadingInterceptor', function ($q, $window,$timeout) {
        var _requestCount = 0;
        var _exibirLoading = function () {
           
            if (_requestCount > 0) {
                $('#jbsLoading').show();
            }
        };
        var _ocultarLoading = function () {

            if (_requestCount <= 0) {
                $('#jbsLoading').hide();
            }
        };

    return {
        'request': function (config) {
            $timeout(function () { _exibirLoading(); },1000);
            _requestCount += 1;
            return config;
        },
        'response': function (response) {
           
            _requestCount =_requestCount - 1;
            _ocultarLoading();
            return response;
        },
        'requestError': function(rejection) {
            // do something on error
            _requestCount = _requestCount - 1;
            _ocultarLoading();
        return $q.reject(rejection);
        },
        'responseError': function (rejection) {
            // do something on error
            _requestCount = _requestCount - 1;
            _ocultarLoading();
            return $q.reject(rejection);
        }
    };


    });

angular.module('cscComponentes').
    factory('noCacheInterceptor', function ($q) {
        
        return {
            'request': function (config) {
                var url = config.url;
                
                if (url.indexOf('/views/') > -1) {
                    console.log(config.url);
                    config.url = config.url + '?v=' + (new Date).getTime();
                    
                }
                return config;
            }
        };
    });