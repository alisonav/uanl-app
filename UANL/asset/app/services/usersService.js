var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/"

app.service('usersService', function ($http) {
    this.CreateUser = function (User) {
        return $http({
            method: 'POST',
            url: baseUrl + 'api/Users/CreateUser',
            data: User
        });
    };
    this.UpdateUser = function (User) {
        return $http({
            method: 'POST',
            url: baseUrl + 'api/Users/UpdateUser',
            data: User
        });
    };
    this.DeleteUser = function (userid) {
        return $http({
            method: 'POST',
            url: baseUrl + 'api/Users/DeleteUser',
            params: { userID: userid }
        });
    };
    this.GetUser = function (userid) {
        return $http({
            method: 'GET',
            url: baseUrl + 'api/Users/GetUser',
            params: { userID: userid }
        });
    };
});