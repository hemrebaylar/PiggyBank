﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public class ZeroFiftyLira : ICoin
    {
        public double radius { get => (23.85/2); set => throw new NotImplementedException(); }
        public double height { get => 1.67; set => throw new NotImplementedException(); }
        public decimal value { get => 0.5m; set => throw new NotImplementedException(); }
    }
}
