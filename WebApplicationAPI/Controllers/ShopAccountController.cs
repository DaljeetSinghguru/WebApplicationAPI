
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

    public class ShopAccountController : ApiController
    {

        //[System.Web.Http.HttpPost]

        //public bool ShopInsertintoAccount(ShipmentModel data)
        //{

        //    IEnumerable<ItemsArray> items = data.ItemsArray;
        //    foreach (var item in items)
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        SqlConnection cn = new SqlConnection(new Login().GetConnectionString());
        //        try
        //        {

        //            //new Login().UpdateAccountHistoryForShoping(data.ItemMasterId, data.PaymentTypeId, data.Student, data.UserId, data.Amount, data.DiscountAmount, data.CampusId, data.COURSE,
        //            //      data.COURSEID, data.ReceiptNumber, data.WebXReceiptNo, data.DocumentGUID, data.PortalTransactionId, data.PortalId, data.BankId, data.InstrumentNo, data.InstrumentDate, data.InstrumentTypeId, data.InstrumentInFavourOf, data.CreatorId, data.OVoucherNo, data.Result, data.Remarks);
        //            new Login().UpdateAccountShop(data.TransectionId, data.HrUserId, data.AccountPost, item.name, item.price, item.quantity, data.Date, data.FirstName,
        //           data.LastName, data.BillingAddress, data.ShippingAddress, data.ContactNumber, data.EmailAddress, data.FromDate, data.totalPrice, data.CouponNumber, data.Active, item.ItemType, item.ItemId);



        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            if (cn.State == ConnectionState.Open)
        //            {
        //                cn.Close();
        //            }
        //            cmd.Dispose();
        //            cn.Dispose();

        //        }
        //    }
        //    return true;

        //}




    }
}

