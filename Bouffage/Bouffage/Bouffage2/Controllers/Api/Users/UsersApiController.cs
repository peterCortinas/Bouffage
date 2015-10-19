using Microsoft.AspNet.Identity.EntityFramework;
//using Bouffage2.Web.Domain;
using Bouffage2.Web.Exceptions;
using Bouffage2.Web.Models;
using Bouffage2.Web.Models.Requests;
using Bouffage2.Web.Models.Requests.Users;
//using Bouffage2.Web.Models.Responses;
//using Bouffage2.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Bouffage2.Controllers.Api.Users
{
    [RoutePrefix("api/users")]

    public class UsersApiController : ApiController
    {

        //[Route("register"), HttpPost]
        //public HttpResponseMessage Register(UsersRegistrationRequestModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            UserService.CreateUser(model.Email, model.Password);
        //            bool isSuccessful = UserService.Signin(model.Email, model.Password);
        //            return Request.CreateResponse(HttpStatusCode.OK, model);
        //        }

        //        catch (IdentityResultException ix)
        //        {
        //            ErrorResponse response = new ErrorResponse(ix.Result.Errors);

        //            return Request.CreateResponse(HttpStatusCode.BadRequest, response);
        //        }

        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }


   //     }
 //   }
}







//[Route("info"), HttpPost, Authorize]
//public HttpResponseMessage Info(UserAddRequestModel model)


//{
//    if (ModelState.IsValid)
//    {
//        string userId = UserService.GetCurrentUserId();
//        bool u = UserService.AddUserData(model, userId);
//        ItemResponse<bool> response = new ItemResponse<bool>();
//        response.Item = u;

//        return Request.CreateResponse(HttpStatusCode.OK, response);
//        //return Request.CreateResponse(HttpStatusCode.OK, model);
//    }
//    else
//    {
//        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//    }
//}


//[Route("info"), HttpDelete, Authorize]
//public HttpResponseMessage Info()
//{
//    if (ModelState.IsValid)
//    {
//        string userId = UserService.GetCurrentUserId();
//        bool u = UserService.DeleteUserData(userId);
//        ItemResponse<bool> response = new ItemResponse<bool>();
//        response.Item = u;

//        return Request.CreateResponse(HttpStatusCode.OK, response);

//    }
//    else
//    {
//        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//    }
//}

//[Route("info"), HttpGet, Authorize]
//public HttpResponseMessage GetInfo()
//{
//    if (ModelState.IsValid)
//    {
//        string userId = UserService.GetCurrentUserId();
//        User u = UserService.Get(userId);
//        ItemResponse<User> response = new ItemResponse<User>();
//        response.Item = u;

//        return Request.CreateResponse(HttpStatusCode.OK, response);

//    }
//    else
//    {
//        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//    }
//}



//[Route("login"), HttpPost]
//public HttpResponseMessage SignIn(UsersLoginRequestModel model)
//{
//    if (ModelState.IsValid)
//    {


//        bool isSuccessful = UserService.Signin(model.email, model.password);

//        if (isSuccessful)
//        {

//            SuccessResponse response = new SuccessResponse();

//            return Request.CreateResponse(HttpStatusCode.OK, response);
//        }

//        else
//        {
//            ErrorResponse response = new ErrorResponse("We were not able to log you in.");
//            return Request.CreateResponse(HttpStatusCode.BadRequest, response);
//        }

//    }

//    else
//    {
//        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//    }
//}

//[Route("password"), HttpPost, Authorize]
//public HttpResponseMessage ChangePassWord(PasswordRequestModel model)
//{
//    if (ModelState.IsValid)
//    {
//        string userId = UserService.GetCurrentUserId();
//        bool isSuccessful = UserService.ChangePassWord(userId, model.Password);

//        if (isSuccessful)
//        {
//            SuccessResponse response = new SuccessResponse();
//            return Request.CreateResponse(HttpStatusCode.OK, response);
//        }

//        else
//        {
//            ErrorResponse response = new ErrorResponse("We were not able to change your password.");
//            return Request.CreateResponse(HttpStatusCode.BadRequest, response);
//        }

//    }
//    else
//    {
//        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
//    }

//}


//[Route("logout"), HttpGet]
//public HttpResponseMessage Logout()
//{
//    if (ModelState.IsValid)
//    {


//        UserService.Logout();

//        SuccessResponse response = new SuccessResponse();

//        return Request.CreateResponse(HttpStatusCode.OK, response);
//    }

//    else
//    {

//        return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
//    }



//}




 }