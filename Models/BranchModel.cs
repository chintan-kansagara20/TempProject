﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Branch")]
    public class BranchModel
    {
        public Guid PKIDBranch { get; set; }
        public Guid GUIDBranch { get; set; }
        public string BranchID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string FAX { get; set; }
        public string EMail { get; set; }
        public Guid? GUIDARAccount { get; set; }
        public Guid? GUIDInvoiceDiscountAccount { get; set; }
        public Guid? GUIDSalesAccount { get; set; }
        public Guid? GUIDReturnsAccount { get; set; }
        public Guid? GUIDTradeDiscount { get; set; }
        public Guid? GUIDCOGSAccount { get; set; }
        public Guid? GUIDShippingChargeAccount { get; set; }
        public Boolean ShippingChargeTaxable { get; set; }
        public string ShippingChargeDescription { get; set; }
        public string ShippingChargeProductID { get; set; }
        public Guid? GUIDOrderDefaultWarehouse { get; set; }
        public Guid? GUIDSpecialOrderDefaultWarehouse { get; set; }
        public string OrderWarehouseSelection { get; set; }
        public Guid? GUIDAPAccount { get; set; }
        public Guid? GUIDPODefaultWarehouse { get; set; }
        public string POWarehouseSelection { get; set; }
        public Guid? GUIDClass { get; set; }
        public Guid? GUIDCurrency { get; set; }
        public Boolean Active { get; set; }
        public Byte[]? Logo { get; set; }
        public string ItemListID { get; set; }
        public string InvoiceDiscountAccountID { get; set; }
        public string SalesAccountSegment { get; set; }
        public string ReturnsAccountSegment { get; set; }
        public string TradeDiscountSegment { get; set; }
        public string COGSAccountSegment { get; set; }
        public string ShippingChargeAccountID { get; set; }
        public string APAccountID { get; set; }
        public string ARAccountID { get; set; }
        public string OrderDefaultWarehouseID { get; set; }
        public string PODefaultWarehouseID { get; set; }
    }
}
