using Bouffage2.Web;
using Bouffage2.Web.Requests;
using Bouffage2.Web.Responses;
//using Bouffage2.Web.Services;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//namespace Bouffage2.Web.Api
//{
//    [RoutePrefix("api/signin")]
    //public class LoginApiController : ApiController
    //    {
    //        [Route, HttpPost]
    //        public HttpResponseMessage LoginValidationPost(LoginRequest model)
    //        {
    //            if (!ModelState.IsValid)
    //            {
    //                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
    //            }
                //bool signInSuccess = UserService.Signin(model.UserName, model.UserPassword);
                //ItemResponse<bool> response = new ItemResponse<bool>();

            //    response.Item = signInSuccess;

            //    return Request.CreateResponse(response);
        //    //}
        //}
//}