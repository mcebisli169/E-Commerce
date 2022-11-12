using ETicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ETicaretSitesi.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.UserName).HasColumnName("Kullanıcı Adı").IsRequired();
            builder.Property(x => x.Password).HasColumnName("Şifre").IsRequired();
        }
    }
}
