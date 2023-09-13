using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("ProductExport")]
    public class ProductExportModel
    {
        public Guid GUIDProduct { get; set; } 
        public string ProductID { get; set; } 
        public Decimal? ListPrice { get; set; }
        public string ListPriceType { get; set; }
        public Boolean? Taxable { get; set; }
        public Boolean TaxByCategory { get; set; }
        public Boolean TaxInPrice { get; set; }
        public Boolean AllowOverride { get; set; }
        public Boolean AllowZero { get; set; }
        public Int16? CommissionType { get; set; }
        public Decimal? CommPct { get; set; }
        public Decimal? CommAmt { get; set; }
        public string AlternateProductID { get; set; }
        public string Unit { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Length { get; set; }
        public Boolean VariableWeight { get; set; }
        public Boolean VariableLength { get; set; }
        public string Specification { get; set; }
        public string ProductPriceCategory { get; set; }
        public Boolean PriceByCategory { get; set; }
        public string ProductClassID { get; set; }
        public Int32? LeadTime { get; set; }
        public string SalesCategory { get; set; }
        public Boolean Discontinued { get; set; }
        public string CostMethod { get; set; }
        public string AlternateUnit { get; set; }
        public Decimal? AlternateUnitConversionFactor { get; set; }
        public string ProductType { get; set; }
        public string InventoryControlType { get; set; }
        public string AssemblyType { get; set; }
        public string CountCycle { get; set; }
        public Boolean Status { get; set; }
        public string Note { get; set; }
        public Boolean Popup { get; set; }
        public string ListPriceUnit { get; set; }
        public string Color { get; set; }
        public Decimal? Height { get; set; }
        public string Size { get; set; }
        public string UPC { get; set; }
        public Boolean VariableHeight { get; set; }
        public Boolean VariableVolume { get; set; }
        public Boolean VariableWidth { get; set; }
        public Decimal? Volume { get; set; }
        public Decimal? Width { get; set; }
        public string TechSpec { get; set; }
        public string WebAddress { get; set; }
        public string AltDescription { get; set; }
        public string Description { get; set; }
        public Boolean NotForResale { get; set; }
        public Int32 MaintainInventoryType { get; set; } 
        public Byte[]? ProductPicture { get; set; }
        public Boolean AvailOnWeb { get; set; }
    }
}
