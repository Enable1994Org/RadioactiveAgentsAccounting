using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class InstRawAmount
    {
        [Column(Order = 0), Key, ForeignKey("Institution")]
        public int InstitutionID { get; set; }

         [Column(Order = 1), Key, ForeignKey("Raw")]
        public int RawID { get; set; }

        public int Amount { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual RAW Raw { get; set; }
    }
}
