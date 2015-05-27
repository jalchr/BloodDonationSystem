(function() {
    'use strict';
    angular.module('eliteApp').controller('RequestCtrl', ['eliteApi',RequestCtrl]);

    function RequestCtrl(eliteApi) {
        var vm = this;

        var request = eliteApi.getRequest();
        vm.request = request;

        console.log(request);
    };
})();