(function () {
    'use strict';

    angular.module('BloodDonationApp').controller('FeedsCtrl', ['BloodDonationApi','$scope', FeedsCtrl]);

    function FeedsCtrl(BloodDonationApi, $scope) {
        var vm = this;
        //start Data Binding functions//
        var data = BloodDonationApi.getRequests();
        console.log(data);
        vm.feeds = data;
        //end Data Binding//
       
        

        //start Accordion function//
        
        $scope.toggleGroup = function (requests) {
            if ($scope.isGroupShown(requests)) {
                $scope.showGroup = null;
            } else {
                $scope.shownGroup = requests;
            }
        }
        $scope.isGroupShown = function (requests) {
            return $scope.shownGroup === requests;
       }

        //end Accordion function//
       
    };
})();