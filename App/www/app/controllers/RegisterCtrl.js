(function () {
    'use strict';
    angular.module('eliteApp').controller('RegisterCtrl', ['$http', 'apictrl', '$scope', '$window', 'toaster', '$stateParams', registerCtrl]);

    function registerCtrl($http, apictrl, $scope, $window, toaster, $stateParams) {
        /*----------------SubmitRegister---------------------*/
        var local = "http://Hasan-PC:17967/api/";
        $scope.user = {};
        $scope.requestId = $stateParams.id;
        $scope.submit = function () {
            $http({
                method: 'POST',
                url: local + 'Register/RegisterMember',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                transformRequest: function (obj) {
                    var str = [];
                    for (var p in obj)
                        str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                    return str.join("&");
                },
                data: {
                    MName: $scope.user.MName,
                    PhoneNum: $scope.user.PhoneNum,
                    MBloodType: $scope.user.MBloodType
                }
            }).success(function () {

                $scope.popsuccess = function () {
                    toaster.pop('alert', "Registration Completed", "");
                };
                $scope.popsuccess();
            });
            //alert($scope.user);
            //$http.post(local + 'Register/RegisterMember', $scope.user)
            //    .success(function (data) {
            //        $scope.myForm.$setPristine();
            //        $scope.user = { MName: '', PhoneNum: '' };
            //        console.log("post ok");
            //        $http.get(local + 'Register/Getnext/' + 1).then(function (result) {

            //            $scope.dat = result.data.register;

            //            $scope.popsuccess = function () {
            //                //toaster.pop('note', "Registration Complete", "");
            //            };
            //            $scope.popsuccess();
            //            console.log($scope.dat);
            //        });
            //    })
            //    .error(function (mName, phoneNum, mBloodType, date) {
            //        $scope.popfailed = function () {
            //            //toaster.pop('error', "Error Registration", "");
            //        };
            //        console.log("post not ok");

            //        $scope.popfailed();
            //    });

        }
        /*----------------SubmitRegister---------------------*/

        $scope.GetPreviousPage = function() {
            $window.history.back();
        };

    }
})();