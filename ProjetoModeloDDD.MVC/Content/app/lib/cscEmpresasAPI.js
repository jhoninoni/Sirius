angular.module("cscServicesAPI", []);
angular.module("cscServicesAPI").factory("empresasAPI", function ($http, $window, config) {

    var _listar = function () {
        return $http.post(config.baseUrl($window) + "Empresa/Listar");
    };

    var _listarEmpresaTipoRefeicao = function () {
        return $http.post(config.baseUrl($window) + "Empresa/ListarEmpresaTipoRefeicao");
    }

    var _inserirTipoRefeicao = function (empresa, tipo) {
        return $http.post(config.baseUrl($window) + "Empresa/InserirRefeicaoEmpresa", { empresa: empresa, tipo: tipo });
    }

    var _removerRefeicaoEmpresa = function (empresa, tipo) {
        return $http.post(config.baseUrl($window) + "Empresa/RemoverRefeicaoEmpresa", { empresa: empresa, tipo: tipo });
    }

    return {
        listar: _listar,
        listarEmpresaTipoRefeicao: _listarEmpresaTipoRefeicao,
        inserirRefeicaoEmpresa: _inserirTipoRefeicao,
        removerRefeicaoEmpresa: _removerRefeicaoEmpresa
    };
});