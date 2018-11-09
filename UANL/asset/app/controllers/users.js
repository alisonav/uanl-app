'use strict';

app.controller('UsersCtrl', ['$rootScope', '$scope', 'usersService', function ($rootScope, $scope, usersService) {
    $rootScope.isAuthenticated = true;

    var user = {
        id: 1,
        name: '',
        username: '',
        email: '',
        status: 0,
        role: 0
    };

    $scope.GetUser = function () {
        usersService.GetUser(user.id)
            .then(function success(data) {
                swal({
                    title: 'Success',
                    text: 'It works!',
                    type: 'success'
                });
            }, function error(data) {
                swal({
                    title: 'Error',
                    text: data.responseText,
                    type: 'error'
                });
            });
    };
}]);