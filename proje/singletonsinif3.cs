using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
   public  class singletonsinif3
    {
       private static singletonsinif3 _TekNesne;
       private static object lockObject = new object();

       private singletonsinif3() { }
       public static singletonsinif3 sinif
       {
           get
           {
               if (_TekNesne ==null )
               {
                   lock (lockObject )
                   {
                       if (_TekNesne == null)
                           _TekNesne = new singletonsinif3();
                   }
               }
               return _TekNesne;
           }
       }
       public int toplam(int s1,int s2)
       {
           return s1 + s2;
       }
    }
}
