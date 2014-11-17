using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class InstIrsAmount
    {
        [Column(Order = 0), Key, ForeignKey("Institution")]
        public int InstitutionID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Irs")]
        public int IrsID { get; set; }

        public int Amount { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual IRS Irs{ get; set; }
    }
}
