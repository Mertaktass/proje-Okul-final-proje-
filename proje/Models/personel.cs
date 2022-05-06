using System;
using System.Collections.Generic;

namespace proje.Models
{
    public partial class personel
    {
        public personel()
        {
            this.ürünler = new List<ürünler>();
        }

        public Nullable<int> personelid { get; set; }
        public string personel_adi { get; set; }
        public string personel_sifre { get; set; }
        public int personel_no { get; set; }
        public Nullable<decimal> telefon { get; set; }
        public virtual ICollection<ürünler> ürünler { get; set; }
    }
}
