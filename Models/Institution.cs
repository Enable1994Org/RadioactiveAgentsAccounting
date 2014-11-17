using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class Institution
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int DistrictID { get; set; }//rajon
        public int ProvinceID { get; set; }//oblast
        public int RegionID { get; set; }
        public DateTime LastInventarisationDate { get; set; }

        public virtual District District { get; set; }
        public virtual Province Province { get; set; }
        public virtual Region Region { get; set; }
        public virtual ObservableCollection<InstRawAmount> InstRawAmounts { get; set; }
        public virtual ObservableCollection<InstIrsAmount> InstIrsAmounts { get; set; }
    }
}
