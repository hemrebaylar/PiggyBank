using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public interface ICoin
    {
        double radius { get; set; }
        double height { get; set; }
        decimal value { get; set; }

    }
}
