
//using Braintree;
//using SlimApi2.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

using SlimApi2.Models;
using System.Collections;
using System.Web.Http.Cors;

namespace SlimApi2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class LoginSellingPortalController : ApiController
    {
        //[System.Web.Http.HttpPost]
        //public bool CheckUserIsLogin(LoginSelling data)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    SqlConnection cn = new SqlConnection(new Login().GetConnectionString());
        //    string strQry = string.Empty;
        //    try
        //    {

        //        strQry = "select count(*) from MST_hrm_user where userLoginId = '" + data.Email + "' and convert(varchar(max), decryptbypassphrase('MAKV2SPBNI99212', Password)) = '" + data.Password + "'";
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = cn;
        //        cn.Open();
        //        cmd.CommandText = strQry;
        //        int ctr = 0;
        //        ctr = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        cmd.Dispose();
        //        cn.Dispose();
        //        if (ctr > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        cmd.Dispose();
        //        cn.Dispose();
        //    }
        //    return false;
        //}




    }
}

