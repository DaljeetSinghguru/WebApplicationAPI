﻿using SlimApi2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SlimApi2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ShopPortalListingByItemTypeController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        //public IEnumerable<ShopPortalListing> Get(string ItemType)
        //{
        //    List<ShopPortalListing> list = new List<ShopPortalListing>();

        //    System.Data.DataTable dt = new Login().PortalListingByItemType(ItemType); //new Login().gettable(" Select distinct w.FromDesignationId, fromdesig.Description as FromDesignationDescription,( isnull(fromuser.FirstName, '') + ' ' + isnull(fromuser.MiddleName, '') + ' ' + isnull(fromuser.LastName, '') ) as FromDesignationUserName, fromuser.HrUserId as FromHrUserId, w.ToDesignationId, todesig.Description as ToDesignationDescription,( isnull(u.FirstName, '') + ' ' + isnull(u.MiddleName, '') + ' ' + isnull(u.LastName, '') ) as ToDesignationUserName , u.HrUserId as ToUserHrUserId from Trn_Com_UserWorkFlow  as w inner join Trn_Hrm_UserRoleCentre as urc on urc.DesignationId = w.ToDesignationId inner join Trn_Hrm_UserRoleCentre as urcfrom on urcfrom.DesignationId = w.FromDesignationId inner join Mst_Hrm_User as u on u.HrUserId = urc.UserId inner join Mst_Hrm_User as fromuser on fromuser.HrUserId = urcfrom.UserId  inner join Mst_Hrm_Designation as todesig on todesig.DesignationId = w.ToDesignationId inner join Mst_Hrm_Designation as fromdesig on fromdesig.DesignationId = w.FromDesignationId where w.Active = 1 and w.WorkFlowId = 3 and   fromuser.HrUserId = " + hrUserId + "  and urcfrom.CentreId=urc.CentreId ");

        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (System.Data.DataRow dr in dt.Rows)
        //        {

        //            list.Add(new ShopPortalListing()
        //            {

        //                CourseName = Convert.ToString(dr["CourseDescription"]),
        //                ItemDescription = Convert.ToString(dr["ItemDescription"]),
        //                ItemId = Convert.ToInt32(dr["ItemId"]),
        //                ItemImage = Convert.ToString(dr["ItemImage"]),
        //                ItemName = Convert.ToString(dr["ItemName"]),
        //                ItemPrice_FromDate = Convert.ToDateTime(dr["FromDate"]),
        //                ItemPrice_ToDate = Convert.ToDateTime(dr["ToDate"]),
        //                ItemType = Convert.ToString(dr["ItemType"]),
        //                MasterCourseId= Convert.ToInt32(dr["MasterCourseId"]),
        //                Price= Convert.ToString(dr["Price"]),
        //                Quantity= Convert.ToInt32(dr["Quantity"]),
        //                Remarks= Convert.ToString(dr["Remarks"]),
        //                Sellable= Convert.ToBoolean(dr["Sellable"]),
        //                TestSetDescription= Convert.ToString(dr["Description"]),
        //                TestSetId= Convert.ToInt32(dr["TestSetId"]),
        //                 ItemStockInHand= Convert.ToString(dr["StockInHand"]),
        //                CenterId = Convert.ToString(dr["CentreId"]),
        //                IsStockPresent= Convert.ToString(dr["IsStockPresent"])
        //            });
        //        }
        //    }
        //    return list;
        //}

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
       
      
    }
}