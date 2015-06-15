var donationApp = angular.module("donationApp", ['ngRoute', 'ngAnimate', 'toaster', "ngSanitize", "ngScrollbar"]);

donationApp.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: "Index.html",
            controller: "logctrl"
        })
          .when('/UserLists', {
              templateUrl: "/CMS/UsersList.html",
              controller: "AddUserCtrl"
          })
          .when('/EditUser/:Id', {
              templateUrl: "/CMS/EditUser.html",
              controller: "EditUserCtrl"
          })
        .when('/membermain/:Id', {
            templateUrl: "/CMS/membermain.html",
            controller: "CreateRequestCtrl"
        })
        .when('/EditRequest/:Id', {
            templateUrl: "/CMS/EditRequest.html",
            controller: "EditRequestCtrl"
        })
         .when('/addUser', {
             templateUrl: "/CMS/addUser.html",
             controller: "AddUserCtrl"
         })
    .otherwise({
        redirectTo: "Index.html"
    });
}
]);

donationApp.filter('fromNow', function () {
    return function (date) {
        return moment.utc(date).toDate();
        //return date.format("H:mm");
    }
});

/*----------------BLOODREQUEST INSERT EDIT DELETE--------------------*/

donationApp.controller("CreateRequestCtrl", function ($scope, $location, $routeParams, $http, $window, $timeout) {

    console.log("BloodRequest contoller");
    sessionStorage.lecsession = sessionStorage.pagelecsession;


    $scope.id = $routeParams.Id;



    $scope.back = function () {
        $window.history.back();
    }
    var date = new Date();
    //mom.format("H:mm");
    //$scope.requestTime = date;

    $scope.createRequest = function () {
        $scope.request.UserId = $scope.id;
        $http.post('/api/BloodRequest/PostBloodRequest', $scope.request).
          success(function (data, status, headers, config) {
              $scope.request = { BloodType: '', UnitsRequired: '' };
              getAllRequests($scope);

              console.log("post ok");

          }).
            error(function (data, status, headers, config) {
                console.log("post not ok");
            });

    }

    var getAllRequests = function () {
        $http.get('/api/BloodRequest/Getall/' + $scope.id).then(function (result) {
            $scope.dat = result.data;
            console.log($scope.dat);
            console.log($scope.idv);
        });
    }
    getAllRequests();
    $timeout(function () {
        $scope.$broadcast('rebuild:me');
    });
});

donationApp.controller("EditRequestCtrl", ["$scope", "$filter", "$routeParams", "$http", "$location", "$window", "$timeout", EditRequestCtrl]);

function EditRequestCtrl($scope, $filter, $routeParams, $http, $location, $window, $timeout) {

    $scope.id = $routeParams.Id;

    //var vm = this;
    $scope.UserId = "";

    $scope.$on('scrollbar.show', function () {
        console.log('Scrollbar show');
    });

    $scope.EditRequest = function () {
        $scope.bloodRequest.UserId = $scope.UserId;
        $http.put('/api/BloodRequest/EditBloodRequest/' + $scope.id, $scope.bloodRequest)
            .success(function (data, status, headers, config) {
                console.log("put BloodRequest ok");
                getRequest();
            })
            .error(function (data, status, headers, config) {
                console.log("put BloodRequest not ok");
            });
    }

    $scope.deletBloodRequest = function (val) {

        $http.delete('/api/BloodRequest/DeleteBloodRequest/' + val)
            .success(function (data, status, headers, config) {
                $location.path("/mainmember");
                console.log("deletepost ok");
            })
            .error(function (data, status, headers, config) {
                console.log("deletepost not ok");

            });
    }


    var getAllRequests = function () {
        $http.get('/api/BloodRequest/Getall/' + $scope.UserId).then(function (result) {
            $scope.dat = result.data;
        });
    }

    var getRequest = function () {
        $http.get('/api/BloodRequest/Getrequest/' + $scope.id).then(function (result) {
            $scope.bloodRequest = result.data;
            $scope.UserId = $scope.bloodRequest.UserId;
            getAllRequests();
            $timeout(function () {
                $scope.$broadcast('rebuild:me');
            });
        });
        
    }
    getRequest();

  
};

/*----------------End BLOODREQUEST INSERT EDIT DELETE--------------------*/

/*-------------------------------User section-------------------------*/

donationApp.controller("AddUserCtrl", ["$scope", "$routeParams", "$http", "$location", "$window", AddUserCtrl]);

function AddUserCtrl($scope, $routeParams, $http, $location, $window) {

    $scope.createUser = function () {
        $http.post('/api/Login/RegisterUser', $scope.user).
          success(function (data, status, headers, config) {
              console.log("post ok");
              $location.path("/UserLists");
          }).
            error(function (data, status, headers, config) {
                console.log("post not ok");
            });
    }




    $scope.deleteUser = function (userId) {

        $http.delete('/api/Login/DeleteUser/' + userId)
            .success(function (data, status, headers, config) {
                console.log("deletepost ok");
                getAll();
            })
            .error(function (data, status, headers, config) {
                console.log("deletepost not ok");
            });
    }


    var getAll = function () {
        $http.get('/api/Login/Getall/').then(function (result) {
            $scope.data = result.data;
            console.log($scope.data);
        });
    }

    getAll();
}

donationApp.controller("EditUserCtrl", ["$scope", "$routeParams", "$http", "$location", "$window", EditUserCtrl]);

function EditUserCtrl($scope, $routeParams, $http, $location, $window) {

    $scope.id = $routeParams.Id;

    $http.get('/api/Login/GetUser/' + $scope.id).then(function (result) {
        $scope.user = result.data;
    });

    $scope.EditUser = function () {
        $http.put('/api/Login/EditUser/' + $scope.id, $scope.user).
          success(function (data, status, headers, config) {
              console.log("post ok");
              $location.path("/UserLists");
          }).
            error(function (data, status, headers, config) {
                console.log("post not ok");
            });
    }

}
/*-------------------------------End AddUser section-------------------------*/


/*-------------------------------LogIn section-------------------------*/

donationApp.controller("logctrl", function ($scope, $routeParams, $http, $location, $window, toaster) {

    console.log("login ctrl");
    $scope.user = { username: '', password: '' };
    $scope.notLoggedIn = true;
    $scope.LoggedIn = false;
    $scope.popfailed = function () {
        toaster.pop('error', "الإسم أو كلمة المرور غير مطابقة", "");
    };
    console.log("post not ok");

    $scope.logverif = function () {
        $http.post('/api/Login/Verif', $scope.user).then(function (result) {
            var loggedResult = result.data;
            if (loggedResult == null) {
                $scope.popfailed();
            } else {
                $scope.LoggedIn = true;
                $scope.notLoggedIn = false;
                $scope.HospitalName = loggedResult.HospitalName;
                $scope.Role = loggedResult.Role;
                $scope.UserName = loggedResult.UserName;
                if (loggedResult.IsAdmin) {
                    $location.path("/UserLists");
                } else {
                    $location.path("/membermain/" + loggedResult.Id);
                }
            }
            console.log($scope.LoggedIn);

        });
    }

    $scope.logout = function () {
        // $cookieStore.remove('login');
        $scope.notLoggedIn = true;
        $scope.LoggedIn = false;
    }
});

/*-------------------------------End LogIn section-------------------------*/

