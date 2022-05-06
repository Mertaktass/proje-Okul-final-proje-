using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace proje.Models.Mapping
{
    public class ürünlerMap : EntityTypeConfiguration<ürünler>
    {
        public ürünlerMap()
        {
            // Primary Key
            this.HasKey(t => t.ürün_serino);

            // Properties
            this.Property(t => t.ürünid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ürün_adi)
                .HasMaxLength(50);

            this.Property(t => t.ürün_modeli)
                .HasMaxLength(50);

            this.Property(t => t.ürün_serino)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ürünler");
            this.Property(t => t.ürünid).HasColumnName("ürünid");
            this.Property(t => t.ürün_adi).HasColumnName("ürün_adi");
            this.Property(t => t.ürün_modeli).HasColumnName("ürün_modeli");
            this.Property(t => t.ürün_serino).HasColumnName("ürün_serino");
            this.Property(t => t.ürün_adedi).HasColumnName("ürün_adedi");
            this.Property(t => t.ürün_tarihi).HasColumnName("ürün_tarihi");
            this.Property(t => t.fiyat).HasColumnName("fiyat");
            this.Property(t => t.personel_no).HasColumnName("personel_no");
            this.Property(t => t.kullanıcıid).HasColumnName("kullanıcıid");

            // Relationships
            this.HasOptional(t => t.kullanıcı)
                .WithMany(t => t.ürünler)
                .HasForeignKey(d => d.kullanıcıid);
            this.HasOptional(t => t.personel)
                .WithMany(t => t.ürünler)
                .HasForeignKey(d => d.personel_no);

        }
    }
}
