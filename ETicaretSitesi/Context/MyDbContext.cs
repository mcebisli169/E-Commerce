using ETicaretSitesi.Configurations;
using ETicaretSitesi.Initializer;
using ETicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicaretSitesi.Context
{
    public class MyDbContext:DbContext
    {
        // Constructor ile MyDbContext içine Dependency Injection ile  DbContextOptions'ı alındı.Base miras alınan sınıfın constructor ' ına parametre göndermek için kullanılır.
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
            
        }

      // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      // {
      //     optionsBuilder.UseSqlServer("server=DESKTOP-0F26066\\SQLEXPRESS; //database=HerşeyBurada;uid=sa;pwd=123");
      //     base.OnConfiguring(optionsBuilder);
      // }
        // veritabanının konfigürasyonlarının yapıldığı yer onmodelcreating(tabloların ismini değiştirebiliriz vb.)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);
            // OrderDetail
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            // AppUserDetail 
            modelBuilder.ApplyConfiguration(new AppUserDetailConfigurations());
            // AppUser
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            // modelBuilder.Entity<OrderDetail>().HasKey("OrderID", "ProductID"); // orderdetail içindeki bu kolonların primarykey olması sağlandı
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        // dbset modellerin veritabanında tablo olarak karşılık bulabilmesi için kullanılır
        public DbSet<AppUser> Users { get; set; } // db ' de Users adında tablo oluşturur
        public DbSet<AppUserDetail> AppUserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
