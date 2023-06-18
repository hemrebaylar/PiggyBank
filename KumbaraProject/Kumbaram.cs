using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public class Kumbaram
    {
        public Kumbaram()
        {
            Mass = 0;
            ElliKurus = 0;
            BirLira = 0;
            BesLira = 0;
            OnLira = 0;
            ToplamTutar = 0;
            BreakCount = 0;
        }
        public double Mass { get; set; }
        public int ElliKurus { get; set; }
        public int BirLira { get; set; }
        public int BesLira { get; set; }
        public int OnLira { get; set; }
        public decimal ToplamTutar { get; set; }
        public int BreakCount { get; set; }

    }
}
