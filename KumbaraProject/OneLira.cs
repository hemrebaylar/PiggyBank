using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public class OneLira : ICoin
    {
        public double radius { get => (26.15/2); set => throw new NotImplementedException(); }
        public double height { get => 1.67; set => throw new NotImplementedException(); }
        public decimal value { get => 1.0m; set => throw new NotImplementedException(); }
    }
}
