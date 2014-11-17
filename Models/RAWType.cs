using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class RAWType
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual RAW Raw { get; set; }
    }
}
