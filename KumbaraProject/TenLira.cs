using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public class TenLira : ICash
    {
        public int length { get => 64; set => throw new NotImplementedException(); }
        public int height { get => 136; set => throw new NotImplementedException(); }
        public double width { get => 0.25; set => throw new NotImplementedException(); }
        public decimal value { get => 10.0m; set => throw new NotImplementedException(); }
    }
}
