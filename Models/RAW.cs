using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class RAW
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ObservableCollection<InstRawAmount> InstRawAmounts{ get; set; }
    }
}
