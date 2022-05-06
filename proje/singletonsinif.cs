using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
   public  class singletonsinif
    {
       private static singletonsinif _TekNesne = new singletonsinif();

       private singletonsinif() { }

       public static singletonsinif sinif
       {
           get
           {
               return _TekNesne;
           }
       }
       public static singletonsinif sinif2()
       {
           return _TekNesne;
       }
       public int toplam(int s1,int s2)
       {
           return s1 + s2;
       }
    }
}
