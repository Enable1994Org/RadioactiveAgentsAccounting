using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class District
    {
        public int ID { get; set; }
        public int Name { get; set; }

        public Institution Institution { get; set; }
    }
}
