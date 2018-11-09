var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/"

var app = angular.module("myApp", ["ngRoute"]);

app.controller('appCtrl', ['$scope', '$rootScope', function ($scope, $rootScope) {
    $rootScope.isAuthenticated = false;
}]);

app.config(function($routeProvider) {
    $routeProvider
    .when("/profile", {
        templateUrl: baseUrl + "Home/UserProfile",
        controller: 'UsersCtrl'
    })
    .when("/changepass", {
        templateUrl: baseUrl + "Home/ChangePassword",
        controller: 'UsersCtrl'
    })
    .when("/login", {
        templateUrl: baseUrl + "Home/Login"
    })
    .otherwise({ redirectTo: '/login' });
});