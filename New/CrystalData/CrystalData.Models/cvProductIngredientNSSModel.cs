using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvProductIngredientNSS")]
    public class cvProductIngredientNSSModel
    {
        public string IngProductID { get; set; } 
        public string IngDescription { get; set; }
        public string IngAltDescription { get; set; }
        public string IngProductClassID { get; set; }
        public string INGProductClassDescription { get; set; }
        public string IngProductType { get; set; } 
        public string IngProductTypeDescription { get; set; }
        public string IngSalesCategory { get; set; }
        public string IngSalesCategoryDescription { get; set; }
        public Boolean IngActiveStatus { get; set; }
        public string Unit { get; set; }
        public string PackageUnit { get; set; }
        public string IngAnalyte { get; set; }
        public Boolean IngAdjustForPotency { get; set; }
        public Decimal? IngPotency { get; set; }
        public Decimal? IngMfgOverage { get; set; }
        public string IngAllergens { get; set; }
        public Int32? IngAllergenSeverity { get; set; }
        public string IngGlutenRating { get; set; }
        public string IngClaimsCerts { get; set; }
        public string IngShelfLife { get; set; }
        public string IngStorageConditions { get; set; }
        public string IngComposition { get; set; }
        public string IngAppearance { get; set; }
        public string IngTaste { get; set; }
        public string IngScent { get; set; }
        public string IngColor { get; set; }
        public string IngTestGroup { get; set; }
        public string IngTestMethod { get; set; }
        public string IngTestSpec { get; set; }
        public Decimal? IngTestMin { get; set; }
        public Decimal? IngTestMax { get; set; }
        public string IngTestDataType { get; set; }
        public string IngTechSpec { get; set; }
        public string IngWebAddress { get; set; }
        public Guid IngGUIDProduct { get; set; } 
        public string IngMetrics { get; set; } 
        public string ProductCategoryID { get; set; }
        public Int32? SpecGroup { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubCategory { get; set; }
    }
}
