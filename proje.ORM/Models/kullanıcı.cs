using System;
using System.Collections.Generic;

namespace proje.ORM.Models
{
    public partial class kullanıcı
    {
        public kullanıcı()
        {
            this.ürünler = new List<ürünler>();
        }

        public int kullanıcıid { get; set; }
        public string kullanıcı_adi { get; set; }
        public string kullanıcı_sifre { get; set; }
        public Nullable<decimal> telefon { get; set; }
        public string mail { get; set; }
        public string kullanıcı_isim { get; set; }
        public string kullanıcı_soyisim { get; set; }
        public virtual ICollection<ürünler> ürünler { get; set; }
    }
}
