﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalData.Models
{
    [Table("IssueCode")]
    public class IssueCodeModel
    {
        public Guid GUIDIssueCode { get; set; } 
        public string IssueCode { get; set; } 
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}
