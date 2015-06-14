(function () {
    'use strict';
    angular.module('eliteApp').controller('BloodRequestCtrl', ['$http', 'apictrl', '$scope', bloodRequestCtrl]);

    function bloodRequestCtrl ($http, apictrl, $scope) {
        var vm = this;
        vm.loadList = function (forceRefresh) {
            apictrl.getrqust(forceRefresh).then(function (data) {
                 //alert("ok");
                vm.bloodRequest = data;
            }).finally(function () {
                $scope.$broadcast('scroll.refreshComplete');
            });
        };
        vm.loadList(false);

        /*
     * if given group is the selected group, deselect it
     * else, select the given group
     */
        $scope.toggleGroup = function (group) {
            if ($scope.isGroupShown(group)) {
                $scope.shownGroup = null;
            } else {
                $scope.shownGroup = group;
            }
        }
        $scope.isGroupShown = function (group) {
            return $scope.shownGroup === group;
        }
    };
})();