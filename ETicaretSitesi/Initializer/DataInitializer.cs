using ETicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;

namespace ETicaretSitesi.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() {Id = 1, UserName="adminStrator",Password= password1, Role=Enums.Role.Admin },
                new AppUser() { Id = 2, UserName = "Mustafa", Password = password2, Role = Enums.Role.User }
            );
             
        }
    }
}
