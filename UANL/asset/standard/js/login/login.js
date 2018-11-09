var getUrl = window.location;
var baseUrl = getUrl.protocol + "//" + getUrl.host + "/"

$("#btnLogin").on("click", function (e) {
	e.preventDefault();
	
	var user = $("#txtUser").val();
	var pwd = $("#txtPass").val();
	
	if (user == "" || pwd == "") {
		swal(
		  'Login',
		  'Es necesario informar usuario y contraseña',
		  'info'
		);
	}
	else {

	    $.ajax({
            method: "POST",
	        url: baseUrl + "Home/AuthenticateUser",
            data: { userName: user, pass: pwd }
	    }).done(function (data) {
	        window.location.href = baseUrl + "Home/Index";
	    }).fail(function (data) {
	        alert('Fail');
	    });
	}
});

$('#btnCreateAccount').on('click', function (e) {
    e.preventDefault();
    window.location.href = baseUrl + "Home/NewUser";
});