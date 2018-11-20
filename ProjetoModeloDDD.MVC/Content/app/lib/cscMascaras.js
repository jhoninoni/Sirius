angular.module("cscMascaras", []);
angular.module("cscMascaras").directive("mascDate", function ($filter) {

	return {
		require: "ngModel",
		link: function (scope, element, attrs, ctrl) {
		    
			var _formatDate = function (date) {
				date = date.replace(/[^0-9]+/g, "");
				if(date.length > 2) {
					date = date.substring(0,2) + "/" + date.substring(2);
				}
				if(date.length > 5) {
					date = date.substring(0,5) + "/" + date.substring(5,9);
				}
				return date;
			};

			element.bind("keyup", function () {
				ctrl.$setViewValue(_formatDate(ctrl.$viewValue));
				ctrl.$render();
				
			});

			ctrl.$parsers.push(function (value) {
				if (value.length === 10) {
					var dateArray = value.split("/");
					return new Date(dateArray[2], dateArray[1]-1, dateArray[0]).getTime();
				}
			});

			ctrl.$formatters.push(function (value) {
				return $filter("date")(value, "dd/MM/yyyy");
			});
		}
	};
});
angular.module("cscMascaras").directive("mascMoney", function ($filter) {

    return {
        require: "ngModel",
        link: function (scope, element, attrs, ctrl) {
		    
            var _formatMoney = function (number) {
                
                number = number.replace(/[^0-9]+/g, "");
               
                number=number.replace(/(\d{2})$/,",$1"); //Coloca a virgula
                number = number.replace(/(\d+)(\d{3},\d{2})$/g, "$1.$2"); //Coloca o primeiro ponto

                var qtdLoop = (number.length-3)/3;
                var count = 0;
                while (qtdLoop > count)
                {
                    count++;
                    number=number.replace(/(\d+)(\d{3}.*)/,"$1.$2"); //Coloca o resto dos pontos
                }
                number=number.replace(/^(0)(\d)/g,"$2"); //Coloca hífen entre o quarto e o quinto dígitos

                return number;

            };

            element.bind("keyup", function () {
                ctrl.$setViewValue(_formatMoney(ctrl.$viewValue));
                ctrl.$render();
				
            });

            ctrl.$parsers.push(function (value) {
                if (value.length > 0) {
                    var value = value.replace(".", "");
                    return value.replace(",",".");
                }
            });

            ctrl.$formatters.push(function (value) {
                return value;
            });
        }
    };
});