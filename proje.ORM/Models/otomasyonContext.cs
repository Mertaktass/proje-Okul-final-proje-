using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using proje.ORM.Models.Mapping;

namespace proje.ORM.Models
{
    public partial class otomasyonContext : DbContext
    {
        static otomasyonContext()
        {
            Database.SetInitializer<otomasyonContext>(null);
        }

        public otomasyonContext()
            : base("Name=otomasyonContext")
        {
        }

        public DbSet<kullanıcı> kullanıcı { get; set; }
        public DbSet<personel> personels { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ürünler> ürünler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new kullanıcıMap());
            modelBuilder.Configurations.Add(new personelMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new ürünlerMap());
        }
    }
}
