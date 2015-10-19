using Microsoft.Owin.Security;
using Bouffage2.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Bouffage2.Web.Exceptions;
using System.Data.SqlClient;
using Bouffage2.Web.Models.Requests.Users;
//using Bouffage2.Web.Domain;
//using Bouffage.Data;
using System.Data;
//using Bouffage2.Web.Enums;
//using Bouffage2.Web.Models.Requests.Content;
//using Bouffage2.Web.Domain.Admin;

namespace Bouffage2.Web.Services
{
    public class UserService : BaseService
    {

        //public static User Get(string userId)
        //{
        //    User u = null;

        //    DataProvider.ExecuteCmd(GetConnection, "dbo.Users_SelectInfoByUserId_V3"
        //        , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //        {
        //            paramCollection.AddWithValue("@UserId", userId);

        //        }
        //    , map: delegate (IDataReader reader, short set)
        //    {
        //        u = new User();

        //        MapUser(u, reader);

        //    });


        //    return u;
        //}



        //public static List<AdminUser> GetForAdmin(string userId = null)
        //{
        //    List<AdminUser> users = null;

        //    DataProvider.ExecuteCmd(GetConnection, "dbo.Users_SelectAll_ForAdmin"
        //        , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //        {
        //            // paramCollection.AddWithValue("@UserId", userId);

        //        }
        //        , map: delegate (IDataReader reader, short set)
        //        {
        //            AdminUser u = new AdminUser();

        //            MapUser(u, reader);

        //            if (users == null)
        //                users = new List<AdminUser>();

        //            users.Add(u);

        //        });

        //    return users;
        //}

        //private static void MapUser(User u, IDataReader reader)
        //{
        //    int fieldCount = reader.FieldCount;

        //    int startingIndex = 0; //startingOrdinal


        //    AdminUser au = u as AdminUser;

        //    if (au != null)
        //    {
        //        au.Id = reader.GetSafeInt32(startingIndex++);
        //        au.UserId = reader.GetSafeString(startingIndex++);
        //    }
        //    else
        //    {
        //        startingIndex = 2;
        //    }


        //    u.FirstName = reader.GetSafeString(startingIndex++);
        //    u.LastName = reader.GetSafeString(startingIndex++);

        //    u.Email = reader.GetSafeString(startingIndex++);
        //    u.Dob = reader.GetSafeDateTime(startingIndex++);
        //    u.Phone = reader.GetSafeString(startingIndex++);
        //    u.Photo = reader.GetSafeString(startingIndex++);

        //    u.Gender = reader.GetSafeEnum<Gender>(startingIndex++);

        //    u.CitizenLegalStatus = reader.GetSafeEnum<CitizenLegalStatus>(startingIndex++);
        //    u.LanguagePreference = reader.GetSafeEnum<LanguagePreference>(startingIndex++);
        //    u.EthnicityRace = reader.GetSafeEnum<EthnicityRace>(startingIndex++);
        //    u.PoliticalAffiliation = reader.GetSafeEnum<PoliticalAffiliation>(startingIndex++);
        //    u.Felony = reader.GetSafeEnum<Felony>(startingIndex++);

        //    u.Status = reader.GetSafeEnum<UserStatus>(startingIndex++); ;

        //    int stateId = reader.GetSafeInt32(startingIndex++);

        //    if (stateId > 0)
        //    {
        //        u.Location = new Address();
        //        u.Location.State = new StateProvince();

        //        u.Location.State.Id = stateId;
        //        u.Location.State.CountryCode = reader.GetSafeString(startingIndex++);
        //        u.Location.State.StateCode = reader.GetSafeString(startingIndex++);
        //        u.Location.State.RegionName = reader.GetSafeString(startingIndex++);

        //        u.Location.UId = reader.GetGuid(startingIndex++);
        //        u.Location.Line1 = reader.GetSafeString(startingIndex++);
        //        u.Location.Line2 = reader.GetSafeString(startingIndex++);
        //        u.Location.City = reader.GetSafeString(startingIndex++);
        //        u.Location.Zip = reader.GetSafeString(startingIndex++);
        //        u.Location.Latitude = reader.GetSafeDouble(startingIndex++);
        //        u.Location.Longitude = reader.GetSafeDouble(startingIndex++);
        //    }

        //}

        //public static bool DeleteUserData(string userId)
        //{
        //    int recordsAffected = 0;

        //    recordsAffected = DataProvider.ExecuteNonQuery(GetConnection, "dbo.Users_Delete"
        //     , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //     {
        //         paramCollection.AddWithValue("@UserId", userId);

        //     }, returnParameters: null);

        //    return recordsAffected > 0;
        //}

        //public static bool AddUserData(UserAddRequestModel model, string userId)
        //{
        //    int recordsAffected = 0;

        //    recordsAffected = DataProvider.ExecuteNonQuery(GetConnection, "dbo.Users_Upsert_V2"
        //     , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //     {
        //         paramCollection.AddWithValue("@UserId", userId);

        //         paramCollection.AddWithValue("@Firstname", model.FirstName);

        //         paramCollection.AddWithValue("@Lastname", model.LastName);

        //         paramCollection.AddWithValue("@Dob", model.Dob);

        //         paramCollection.AddWithValue("@GenderId", model.Gender);

        //         paramCollection.AddWithValue("@CitizenLegalStatusId", model.CitizenLegalStatus);

        //         paramCollection.AddWithValue("@LanguagePreferenceId", model.LanguagePreference);

        //         paramCollection.AddWithValue("@EthnicityRaceId", model.EthnicityRace);

        //         paramCollection.AddWithValue("@PoliticalAffiliationId", model.PoliticalAffiliation);

        //         paramCollection.AddWithValue("@Line1", model.Location.Line1);

        //         paramCollection.AddWithValue("@Line2", model.Location.Line2);

        //         paramCollection.AddWithValue("@StateId", model.Location.State);

        //         paramCollection.AddWithValue("@City", model.Location.City);

        //         paramCollection.AddWithValue("@PostalCode", model.Location.Zip);

        //         paramCollection.AddWithValue("@FelonyId", model.Felony);

        //         paramCollection.AddWithValue("@Photo", model.Photo);

        //         paramCollection.AddWithValue("@Latitude", model.Location.Latitude);

        //         paramCollection.AddWithValue("@Longitude", model.Location.Longitude);

        //     }, returnParameters: null

        //);

        //    return recordsAffected > 0;

        //}

        private static ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }

        }

        //private static ApplicationUserManager GetUserManager()
        //{
        //    //var userStore = new UserStore<IdentityUser>();
        //    //var userManager = new UserManager<IdentityUser>(userStore);
        //    //return userManager;
        //    return UserManager;
        //}

        //public static IdentityUser CreateUser(string email, string password)
        //{
        //    ApplicationUserManager userManager = GetUserManager();



        //    ApplicationUser newUser = new ApplicationUser { UserName = email, Email = email, LockoutEnabled = false };
        //    IdentityResult result = null;
        //    try
        //    {
        //        result = userManager.Create(newUser, password);

        //    }
        //    catch
        //    {

        //        throw;// new IdentityResultException(result);

        //    }

        //    if (result.Succeeded)
        //    {

        //        UserInit(newUser.Id);
        //        //
        //        return newUser;
        //    }
        //    else
        //    {
        //        throw new IdentityResultException(result);
        //    }
        //}


        //public static void UserInit(string userId)
        //{
        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.Users_Init"

        //    , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //    {

        //        paramCollection.AddWithValue("@UserId", userId);



        //    });

        //}

        //public static void UpdateStatus(string userId, short status)
        //{
        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.Users_UpdateStatus"

        //    , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //    {

        //        paramCollection.AddWithValue("@UserId", userId);
        //        paramCollection.AddWithValue("@status", status);




        //    });

        //}

        //public static bool Signin(string emailaddress, string password)
        //{
        //    bool result = false;

        //    ApplicationUserManager userManager = GetUserManager();
        //    IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

        //    ApplicationUser user = userManager.Find(emailaddress, password);
        //    if (user != null)
        //    {
        //        ClaimsIdentity signin = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
        //        authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = true }, signin);
        //        result = true;

        //    }
        //    return result;
        //}

        //public static bool IsUser(string emailaddress)
        //{
        //    bool result = false;

        //    ApplicationUserManager userManager = GetUserManager();
        //    IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

        //    ApplicationUser user = userManager.FindByEmail(emailaddress);


        //    if (user != null)
        //    {

        //        result = true;

        //    }

        //    return result;
        //}

        //public static ApplicationUser GetUser(string emailaddress)
        //{


        //    ApplicationUserManager userManager = GetUserManager();
        //    IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

        //    ApplicationUser user = userManager.FindByEmail(emailaddress);

        //    return user;
        //}


        //public static ApplicationUser GetUserById(string userId)
        //{

        //    ApplicationUserManager userManager = GetUserManager();
        //    IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

        //    ApplicationUser user = userManager.FindById(userId);

        //    return user;
        //}

        //public static bool ChangePassWord(string userId, string newPassword)
        //{
        //    bool result = false;

        //    if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(newPassword))
        //    {
        //        throw new Exception("You must provide a userId and a password");
        //    }

        //    ApplicationUser user = GetUserById(userId);

        //    if (user != null)
        //    {

        //        ApplicationUserManager userManager = GetUserManager();

        //        userManager.RemovePassword(userId);
        //        IdentityResult res = userManager.AddPassword(userId, newPassword);

        //        result = res.Succeeded;

        //    }

        //    return result;
        //}

        //public static Guid Forgot(string userId, short tokenType)
        //{
        //    Guid g = Guid.Empty;//000-0000-0000-0000

        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.UserToken_Insert"
        //      , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //      {

        //          paramCollection.AddWithValue("@UserId", userId);

        //          paramCollection.AddWithValue("@TokenType", tokenType);


        //          SqlParameter p = new SqlParameter("@Token", System.Data.SqlDbType.UniqueIdentifier);
        //          p.Direction = System.Data.ParameterDirection.Output;


        //          paramCollection.Add(p);

        //      }, returnParameters: delegate (SqlParameterCollection param)
        //      {
        //          Guid.TryParse(param["@Token"].Value.ToString(), out g);
        //      }
        //   );

        //    return g;

        //}


        //public static bool Logout()
        //{
        //    bool result = false;

        //    IdentityUser user = GetCurrentUser();

        //    if (user != null)
        //    {
        //        IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        //        authenticationManager.SignOut();
        //        result = true;
        //    }

        //    return result;
        //}


        //public static IdentityUser GetCurrentUser()
        //{
        //    if (!IsLoggedIn())
        //        return null;
        //    ApplicationUserManager userManager = GetUserManager();

        //    IdentityUser currentUserId = userManager.FindById(GetCurrentUserId());
        //    return currentUserId;
        //}

        //public static string GetCurrentUserId()
        //{
        //    return HttpContext.Current.User.Identity.GetUserId();
        //}


        //public static bool IsLoggedIn()
        //{
        //    return !string.IsNullOrEmpty(GetCurrentUserId());

        //}

        //public static Guid GetResetToken(ResetPassWordAddRequestModel model, Guid token)
        //{
        //    Guid g = Guid.Empty;//000-0000-0000-0000

        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.UserToken_Insert"
        //     , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //     {

        //         paramCollection.AddWithValue("@Token", token);

        //         SqlParameter p = new SqlParameter("@Token", System.Data.SqlDbType.UniqueIdentifier);
        //         p.Direction = System.Data.ParameterDirection.Output;

        //         paramCollection.Add(p);
        //     }, returnParameters: delegate (SqlParameterCollection param)
        //     {

        //         Guid.TryParse(param["@Token"].Value.ToString(), out g);

        //     });

        //    return g;

        //}

        //public static string GetUserIdByToken(Guid token)
        //{
        //    string user = "@UserId";

        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.UserToken_SelectByTokenId"
        //     , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //     {
        //         paramCollection.AddWithValue("@Token", token);

        //         SqlParameter p = new SqlParameter("@UserId", System.Data.SqlDbType.UniqueIdentifier);
        //         p.Direction = System.Data.ParameterDirection.Output;
        //         paramCollection.Add(p);

        //     }, returnParameters: delegate (SqlParameterCollection param)
        //     {
        //         user = param["@UserId"].Value.ToString();

        //     });

        //    return user;

        //}

        //public static void DeleteToken(Guid Token)
        //{
        //    DataProvider.ExecuteNonQuery(GetConnection, "dbo.UserToken_DeleteToken"
        //     , inputParamMapper: delegate (SqlParameterCollection paramCollection)
        //     {
        //         SqlParameter p = new SqlParameter("@Token", System.Data.SqlDbType.UniqueIdentifier);

        //         paramCollection.AddWithValue("@Token", Token);

        //     });

        //}

    }
}
