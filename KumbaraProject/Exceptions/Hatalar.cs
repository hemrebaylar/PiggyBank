using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KumbaraProject.Exceptions
{
    public class Hatalar
    {
        public static string KumbaraDoldu
        {
            get => "Kumbara Doldu. Para Atamazsınız!";
        }
        public static string KumbaraYenilendi
        {
            get => "Kumbara Yapıştırıldı. Para Atabilirsiniz!";
        }
        public static string KumbaraYapismaz
        {
            get => "Kumbara Tekrar Yapıştırılamaz!";
        }
        public static string KumbaraZatenKirik
        {
            get => "Kumbara Zaten Kırık Durumda!";
        }
        public static string KirikDegil
        {
            get => "Kumbara Kırık Değil Ki Yapıştırılsın!";
        }
    }
}
