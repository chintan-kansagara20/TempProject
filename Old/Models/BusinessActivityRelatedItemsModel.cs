using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("BusinessActivityRelatedItems")]
    public class BusinessActivityRelatedItemsModel
    {
        public Guid GUIDIssueXref { get; set; }
        public Guid GUIDIssue { get; set; }
        public Guid? GUIDLink { get; set; }
        public Int32? TreePosition { get; set; }
        public string XrefType { get; set; }
        public string RelatedItemType { get; set; }
        public Boolean? PrimaryReference { get; set; }
        public Boolean AddressOverride { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string ActivityID { get; set; }
        public string RelatedItem { get; set; }
        public string RelatedItemDescription { get; set; }
        public Guid? GUIDIssueExternalLinkType { get; set; }
        public string FullAddress { get; set; }
    }
}
