using System.Collections.Generic;

namespace ETicaretSitesi.Models
{
    public class Order:BaseEntity
    {

        public int AppUserId { get; set; } // foreignkey appuser tablosunun anahtarı
        // Relational Property

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
