using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject
{
    public interface ICash
    {
        int length { get; set; }
        int height { get; set; }
        double width { get; set; }
        decimal value { get; set; }
    }
}
