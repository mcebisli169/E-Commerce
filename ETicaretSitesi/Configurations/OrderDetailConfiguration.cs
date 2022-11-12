using ETicaretSitesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace ETicaretSitesi.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Ignore(x => x.Id); // orderdetail içindeki ID alanının db ye aktarılmasın.Yukarıdaki kullanım ile alttaki kullanım aynıdır.
            builder.HasKey(x => new { x.OrderId, x.ProductId });
        }
    }
}
