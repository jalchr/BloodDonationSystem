(function () {
    'use strict';
    angular.module('eliteApp').controller('BloodRequestCtrl', ['$http', 'apictrl', '$scope', '$window','DSCacheFactory', bloodRequestCtrl]);

    function bloodRequestCtrl($http, apictrl, $scope, $window, DSCacheFactory) {
        var vm = this;
        var cache = DSCacheFactory.get("RegisterCache");
        vm.loadList = function (forceRefresh) {
            apictrl.getrqust(forceRefresh).then(function (data) {
                 //alert("ok");
                vm.bloodRequest = data;

                if (cache == undefined) {
                    vm.isRegistered = false;
                } else {
                    vm.isRegistered = true;
                }
            
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