angular.module("cscServicesAPI").factory("pivoTableAPI", function ($http, $window, config) {

    var _listarCampos = function (view) {
        return $http.post(config.baseUrl($window) + "PivoTable/Colunas", {view:view});
    };

    return {
        listarCampos: _listarCampos
    };
});