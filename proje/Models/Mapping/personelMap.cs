using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace proje.Models.Mapping
{
    public class personelMap : EntityTypeConfiguration<personel>
    {
        public personelMap()
        {
            // Primary Key
            this.HasKey(t => t.personel_no);

            // Properties
            this.Property(t => t.personel_adi)
                .HasMaxLength(50);

            this.Property(t => t.personel_sifre)
                .HasMaxLength(50);

            this.Property(t => t.personel_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("personel");
            this.Property(t => t.personelid).HasColumnName("personelid");
            this.Property(t => t.personel_adi).HasColumnName("personel_adi");
            this.Property(t => t.personel_sifre).HasColumnName("personel_sifre");
            this.Property(t => t.personel_no).HasColumnName("personel_no");
            this.Property(t => t.telefon).HasColumnName("telefon");
        }
    }
}
