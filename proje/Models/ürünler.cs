using System;
using System.Collections.Generic;

namespace proje.Models
{
    public partial class ürünler
    {
        public int ürünid { get; set; }
        public string ürün_adi { get; set; }
        public string ürün_modeli { get; set; }
        public int ürün_serino { get; set; }
        public Nullable<decimal> ürün_adedi { get; set; }
        public Nullable<System.DateTime> ürün_tarihi { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<int> personel_no { get; set; }
        public Nullable<int> kullanıcıid { get; set; }
        public virtual kullanıcı kullanıcı { get; set; }
        public virtual personel personel { get; set; }
    }
}
