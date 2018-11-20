angular.module("cscPlanejamento").controller("gridCtrl", function ($scope, empresasAPI) {


    empresasAPI.listar().then(function (resp) {

        var empresas = resp.data;
        var colunas = [];

      /*  Object.keys(empresas[0]).forEach(function (key) {
            colunas.push({ name: key, width: Object.keys(empresas[0]).length / 100 + '%' });
        });*/
        
        $scope.dados = empresas;

        /*$scope.gridOptions = {
            enableSorting: true,
            enableFiltering: true,
            showTreeExpandNoChildren: true,
            columnDefs: colunas,
            onRegisterApi: function (gridApi) {
                $scope.gridApi = gridApi;
                $scope.gridApi.treeBase.on.rowExpanded($scope, function (row) {
                    if (row.entity.$$hashKey === $scope.gridOptions.data[50].$$hashKey && !$scope.nodeLoaded) {
                        $interval(function () {
                            $scope.gridOptions.data.splice(51, 0,
                              { name: 'Dynamic 1', gender: 'female', age: 53, company: 'Griddable grids', balance: 38000, $$treeLevel: 1 },
                              { name: 'Dynamic 2', gender: 'male', age: 18, company: 'Griddable grids', balance: 29000, $$treeLevel: 1 }
                            );
                            $scope.nodeLoaded = true;
                        }, 2000, 1);
                    }
                });
            }
        };*/

    });
        var gerarGrid = function (colunas) {

    }

    

});