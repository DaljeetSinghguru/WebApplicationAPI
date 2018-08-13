using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimApi2.Models
{
    public class ShopPortalListing
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Remarks { get; set; }
        public int Quantity { get; set; }
        public bool Sellable { get; set; }
        public string ItemType { get; set; }
        public int TestSetId { get; set; }
        public DateTime ItemPrice_FromDate { get; set; }
        public DateTime ItemPrice_ToDate { get; set; }
        public int MasterCourseId { get; set; }
        public string CourseName { get; set; }
        public string Price { get; set; }
        public string TestSetDescription { get; set; }
        public string ItemImage { get; set; }
        public string ItemStockInHand { get; set; }
        public string CenterId { get; set; }
        public string IsStockPresent { get; set; }
    }
}