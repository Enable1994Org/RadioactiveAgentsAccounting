using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveAgentsAccounting.Models
{
    public class DataInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var districts = new List<District>{
                new District() { 
                    Name = "Kyiv"
                } 
            };

            districts.ForEach(category => context.Districts.Add(category));
        }
    }
}
