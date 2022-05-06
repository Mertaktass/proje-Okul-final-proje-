using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
     public class singletonsinif2
    {
         private static singletonsinif2 _TekNesne;
         private singletonsinif2() { }

         public static singletonsinif2 sinif
         {
             get
             {
                 if (_TekNesne == null)
                     _TekNesne = new singletonsinif2();
                 return _TekNesne;

             }
         }
         public int toplam(int s1,int s2)
         {
             return s1 + s2;
         }
    }
}
