


bouffage.services.users = {

	update: function (myData, onsuccess, onerror) {

		var url = "/api/users/info";

		var settings = {
			cache: false
                , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
                , data: myData
                , dataType: "json"
                , success: onsuccess
                , error: onerror
                , type: "POST"
		};

		$.ajax(url, settings);

	},

	get: function (onsuccess, onerror) {



		var url = "/api/users/info";

		var settings = {
			cache: false
                , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
                , dataType: "json"
                , success: onsuccess
                , error: onerror
                , type: "GET"
		};
		$.ajax(url, settings);
	},



	getPollLocationsByGeo: function (data) {

		var url = "/api/voters/GetMyPolls";

		var settings = {
			cache: false
                , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
                , dataType: "json"
                , data: data
                , success: electa.page.getPollsByGeoSuccess
                , error: onerror
                , type: "POST"
		};
		$.ajax(url, settings);
	}

    , requestEmail: function (emailSubmit, onSuccess, onError) {

    	var url = "/api/email/ForgotPassWord";


    	var settings = {
    		cache: false
            , data: emailSubmit
            , dataType: "json"
            , success: onSuccess
            , error: onError
            , type: "POST"
    	};

    	$.ajax(url, settings);

    }
    , resetPassword: function (reset, token, onSuccess, onError) {

    	var url = "/api/email/ResetPassWord/" + token;


    	var settings = {
    		cache: false
            , data: reset
            , dataType: "json"
            , success: onSuccess
            , error: onError
            , type: "POST"
    	};



    	$.ajax(url, settings);

    }
    , changePassword: function (myData, onsuccess, onerror) {

    	var url = "/api/users/password";

    	var settings = {
    		cache: false
                , contentType: "application/x-www-form-urlencoded; charset=UTF-8"
                , data: myData
                , dataType: "json"
                , success: onsuccess
                , error: onerror
                , type: "POST"
    	};

    	$.ajax(url, settings);

    }

}




