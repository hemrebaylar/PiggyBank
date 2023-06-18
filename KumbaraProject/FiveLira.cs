using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public class FiveLira : ICash
    {
        public FiveLira()
        {
            length = 64;
            height = 130;
            width = 0.25;
            value = 5.0m;
        }

        public int length { get; set; }
        public int height { get; set; }
        public double width { get; set; }
        public decimal value { get; set; }
    }
}
