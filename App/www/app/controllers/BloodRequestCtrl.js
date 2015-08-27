var baseService = "http://localhost:17967/api/";

(function () {
    'use strict';
    angular.module('eliteApp').controller('BloodRequestCtrl', ['$http', 'apictrl', '$scope', '$window','$location','DSCacheFactory', bloodRequestCtrl]);

    function bloodRequestCtrl($http, apictrl, $scope, $window,$location, DSCacheFactory) {
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


        $scope.donate = function (id) {
            //$http.put('/api/Login/EditUser/' + $scope.id, $scope.user).
            $http.post(baseService + "BloodRequest/PutRegister/" + id).success(function (data) {
                $location.path("/home");
                console.log("received one lecture via http ", data, status);
            })
           .error(function () {
               console.log("error get one lecture");

           });
          
        }
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