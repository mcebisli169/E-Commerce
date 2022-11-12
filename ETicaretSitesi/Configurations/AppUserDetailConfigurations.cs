using ETicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ETicaretSitesi.Configurations
{
    public class AppUserDetailConfigurations:IEntityTypeConfiguration<AppUserDetail>
    {
        public void Configure(EntityTypeBuilder<AppUserDetail> builder)
        {
            builder.Property(x => x.FirstName).HasColumnName("Ad").IsRequired();//zorunlu alan
            builder.Property(x => x.LastName).HasColumnName("Soyad");
            builder.Property(x => x.PhoneNumber).HasColumnName("Telefon No");
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
        }
    }
}
