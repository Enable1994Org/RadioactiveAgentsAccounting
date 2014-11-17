using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class IRS
    {
        public int ID { get; set; }
        public int Name { get; set; }

        public virtual ObservableCollection<InstIrsAmount> InstIrsAmount { get; set; }
    }
}
