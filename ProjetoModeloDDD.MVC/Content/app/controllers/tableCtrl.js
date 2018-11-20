angular.module("cscPlanejamento").controller("tableCtrl", function ($scope, pivoTableAPI, empresasAPI,$timeout) {

    $scope.optLinhas =  function (drag) {

        var existel = $scope.linhas.some(function (item) {
            return drag[0].id == item.nome;
        });

        var existec = $scope.colunas.some(function (item) {
            return drag[0].id == item.nome;
        });
            
        return ! (existec || existel);       
    }

    $scope.optColumns = function (drag) {

        var existel = $scope.linhas.some(function (item) {
            return drag[0].id == item.nome;
        });
        
        var existec = $scope.colunas.some(function (item) {
            return drag[0].id == item.nome;
        });
            
        return ! (existec || existel);
    }
    
    var c = this;
    
    // Funções do controller

    c.campos = function (lista) {

        var campos = [];
        var peso = 0;

        lista.forEach(function (cp) {
            peso += cp.Peso;
        });

        lista.forEach(function (cp) {

            if (cp.Peso > 0) campos.push({
                nome: cp.Coluna,
                width: ((cp.Peso * 100) / peso) + '%',
                estilo: cp.Estilo,
                func:cp.Func
            });
        });

        return campos;
    }

    c.executado = function (valor,valor2) {

        console.log(valor + ' - ' + valor2);
    }

    c.carregarView = function () {

        pivoTableAPI.listarCampos('Empresa').then(function (resp) {
            
            if (!resp.data.length) return;            
            $scope.campos = c.campos(resp.data);           
        });
    }

    c.buscarDados = function(){
    
        if (!($scope.colunas.length > 0)) {

            //$scope.lista = "";

        }


        empresasAPI.listar().then(function (resp) {

            var empresas = resp.data;
            $scope.lista = empresas;
        });
    
    }
    
    //$scope
    $scope.exec = function (func, item) {

        var parans = func.substring(func.indexOf('(')).match(/\w+/ig);

        parans.forEach(function (param) {
            func = func.replace(param, item[param]);
        });

        eval(func);
    }

    $scope.colunas = [];
    $scope.linhas = [];

    $scope.removerColuna = function (indice) {
        $scope.colunas.splice(indice,1);
    }

    $scope.removerLinha = function (indice) {
        $scope.linhas.splice(indice, 1);
    }

    $scope.remover = function (id) {

        $scope.linhas = $scope.linhas.filter(function (item) {
            return id != item.nome;
        });

        $scope.colunas = $scope.colunas.filter(function (item) {
            return id != item.nome;
        });
    }


    $scope.gerar = function () {
        c.buscarDados();
    }

    $scope.selecionado = function(id){
        return( $scope.linhas.some(function (item) {
            return id == item.nome;
        }) || $scope.colunas.some(function (item) {
            return id == item.nome;
        }));
    }

    //Chamada inicial 

    c.carregarView();
});