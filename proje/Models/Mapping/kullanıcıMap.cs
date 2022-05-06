using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace proje.Models.Mapping
{
    public class kullanıcıMap : EntityTypeConfiguration<kullanıcı>
    {
        public kullanıcıMap()
        {
            // Primary Key
            this.HasKey(t => t.kullanıcıid);

            // Properties
            this.Property(t => t.kullanıcı_adi)
                .HasMaxLength(50);

            this.Property(t => t.kullanıcı_sifre)
                .HasMaxLength(50);

            this.Property(t => t.mail)
                .HasMaxLength(50);

            this.Property(t => t.kullanıcı_isim)
                .HasMaxLength(50);

            this.Property(t => t.kullanıcı_soyisim)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("kullanıcı");
            this.Property(t => t.kullanıcıid).HasColumnName("kullanıcıid");
            this.Property(t => t.kullanıcı_adi).HasColumnName("kullanıcı_adi");
            this.Property(t => t.kullanıcı_sifre).HasColumnName("kullanıcı_sifre");
            this.Property(t => t.telefon).HasColumnName("telefon");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.kullanıcı_isim).HasColumnName("kullanıcı_isim");
            this.Property(t => t.kullanıcı_soyisim).HasColumnName("kullanıcı_soyisim");
        }
    }
}
