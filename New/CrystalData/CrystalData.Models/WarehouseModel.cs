using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("Warehouse")]
    public class WarehouseModel
    {
        public Guid GUIDWarehouse { get; set; } 
        public string WarehouseID { get; set; }
        public string Description { get; set; }
        public Guid? AssociatedGUIDBranch { get; set; }
        public Guid? GUIDInventoryAccount { get; set; }
        public Guid? GUIDPurchaseAccount { get; set; }
        public Guid? GUIDAdjustmentAccount { get; set; }
        public Guid? GUIDAssemblyLaborAccount { get; set; }
        public Guid? GUIDAssemblyOtherCostAccount { get; set; }
        public Guid? GUIDIssueAccount { get; set; }
        public Guid? GUIDNonInvOffsetAccount { get; set; }
        public Guid? GUIDLaborOffsetAccount { get; set; }
        public Guid? GUIDOtherChargeOffsetAccount { get; set; }
        public Guid? GUIDShippingOffsetAccount { get; set; }
        public Guid? GUIDLandedCostOffsetAccount { get; set; }
        public string Name { get; set; }
        public string ShipToAttentionOf { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string EMail { get; set; }
        public string ShipVia { get; set; }
        public string FOB { get; set; }
        public Boolean MaintainInventory { get; set; }
        public Decimal? LaborCost { get; set; }
        public Boolean Active { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string FAX { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Guid? GUIDGainLossAccount { get; set; }
        public Guid? GUIDPartner { get; set; }
        public string Layout { get; set; }
        public Boolean AllowPicklists { get; set; }
        public string AssociatedBranchID { get; set; }
        public string InventoryAccountID { get; set; }
        public string PurchaseAccountID { get; set; }
        public string AdjustmentAccountID { get; set; }
        public string AssemblyLaborAccountID { get; set; }
        public string AssemblyOtherCostAccountID { get; set; }
        public string GainLossAccountID { get; set; }
        public string Address { get; set; }
    }
}
