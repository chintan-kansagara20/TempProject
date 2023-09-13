using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("cvTrxDetailControlValues")]
    public class cvTrxDetailControlValuesModel
    {
        public Guid GUIDINVTransactionDetail { get; set; } 
        public Int32? RegNumber { get; set; }
        public Int32? TransactionNumber { get; set; }
        public Guid GUIDINVTransaction { get; set; } 
        public string Note { get; set; }
        public Guid? GUIDProduct { get; set; }
        public String EntryValue { get; set; }
        public string PassFail { get; set; }
        public Int32 PassBit { get; set; } 
        public string EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public string CheckedBy { get; set; }
        public DateTime? CheckedOn { get; set; }
        public string Comments { get; set; }
        public string EntryCollection { get; set; }
        public string EntrySeries { get; set; }
        public string Field1Label { get; set; }
        public string Field1Value { get; set; }
        public string Field2Label { get; set; }
        public string Field2Value { get; set; }
        public string Field3Label { get; set; }
        public string Field3Value { get; set; }
        public string Field4Label { get; set; }
        public string Field4Value { get; set; }
        public string Field5Label { get; set; }
        public string Field5Value { get; set; }
        public string Field6Label { get; set; }
        public string Field6Value { get; set; }
        public string Field7Label { get; set; }
        public string Field7Value { get; set; }
        public string Field8Label { get; set; }
        public string Field8Value { get; set; }
        public string Field9Label { get; set; }
        public string Field9Value { get; set; }
        public string Field10Label { get; set; }
        public string Field10Value { get; set; }
        public Decimal? SeriesSum { get; set; }
        public Decimal? SeriesAverage { get; set; }
        public Decimal? SeriesMin { get; set; }
        public Decimal? SeriesMax { get; set; }
    }
}
