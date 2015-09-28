(function () {
    'use strict';

    angular.module('BloodDonationApp').controller('requestDetailsCtrl', ['$stateParams','BloodDonationApi', '$scope', requestDetailsCtrl]);

    function requestDetailsCtrl($stateParams,BloodDonationApi, $scope) {
        var vm = this;
       console.log("$stateParams",$stateParams)
       
        //end Data Binding//


    };
})();