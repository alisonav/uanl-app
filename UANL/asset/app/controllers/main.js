'use strict';

var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/"

app.controller('MainCtrl', ['$rootScope', '$scope', '$locationProvider', '$location', function ($rootScope, $scope, $locationProvider, $location) {
    //$locationProvider.html5Mode(true);
    //$locationProvider.hashPrefix('!');

    $rootScope.isAuthenticated = true;

    $location.url('/profile');
}]);