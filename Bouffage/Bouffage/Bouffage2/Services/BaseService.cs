//using Bouffage.Data.Providers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Bouffage2.Web.Services
{
    public class BaseService
    {
        //protected static  IDao DataProvider
        //{

        //    get { return Bouffage.Data.DataProvider.Instance; }
        //}

        protected static SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(
                System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);


        }
    }
}