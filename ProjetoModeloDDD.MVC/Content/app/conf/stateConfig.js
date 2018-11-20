angular.module("cscPlanejamento").config(function ($stateProvider, $urlRouterProvider) {
   
    var config = {baseUrl:'/cscplanejamento'};
    //var config = {baseUrl:''};
   
    $urlRouterProvider.otherwise("/");

    $stateProvider
     .state("planejamento", {
         url: "/",
         templateUrl: config.baseUrl + '/Content/app/views/Menu.html'
     })
      .state("grid", {
          url: "/grid",
          controller: "gridCtrl",
          templateUrl: config.baseUrl + '/Content/app/views/Grid.html'
          
      })
      .state("table", {
          url: "/table",
          controller: "tableCtrl",
          templateUrl: config.baseUrl + '/Content/app/views/Table.html'

      })/*
    .state("inserirMdl", {
        url: "inserir",
        parent: "principal",
        onEnter: ['$state', '$uibModal', function ($state, $uibModal) {

            var _mdlInstance = $uibModal.open({
                controller: "refeicoesCustosCtrl",
                templateUrl: config.baseUrl + '/Content/appControleCustos/views/refeicoes.html?v=2',
                size: 'lg',
                backdrop: 'static'                
            });

            _mdlInstance.result.finally(function ($result) {
                $state.go('^', null);
            });

        }]

    })
    .state("refeicaoMdl", {
          url: "refeicao",
          parent: "principal",
          params: {
              Data: null,
              Empresa: null              
          },          
          onEnter: ['$state', '$uibModal', '$stateParams', function ($state, $uibModal, $stateParams) {

              if (!$stateParams.Empresa || $stateParams.Empresa == null) {
                  $state.go('principal');
                  return;
              }

              var _mdlInstance = $uibModal.open({
                  controller: "refeicoesCustosCtrl",
                  templateUrl: config.baseUrl + '/Content/appControleCustos/views/refeicoes.html?v=2',
                  size: 'lg',
                  backdrop: 'static'
              });

              _mdlInstance.result.finally(function ($result) {
                  $state.go('^', null);
              });

          }]
          
      })*/;
});