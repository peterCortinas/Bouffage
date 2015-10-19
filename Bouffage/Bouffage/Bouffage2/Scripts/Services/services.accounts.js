bouffage.services.accounts = {};
//This service is not currently being called. The Ajax calls are being made right in the JavaScript.
bouffage.services.accounts.login = function (formData, onSuccess, onError) {
	var url = '/api/login/';
	var settings = {
		dataType: 'JSON',
		type: 'post',
		data: formData,
		success: onSuccess,
		error: onError
	};
	$.ajax(url, settings);
}