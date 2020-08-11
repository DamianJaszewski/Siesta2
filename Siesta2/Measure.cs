using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesta2
{
    public class Measure
    {
        public int Id_Measure { get; set; }
        public string Name { get; set; }
        public string MeasureInfo
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
