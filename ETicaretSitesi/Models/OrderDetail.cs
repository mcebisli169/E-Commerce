using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretSitesi.Models
{
    public class OrderDetail : BaseEntity
    {
        [Key,Column(Order=1)] // key keyword db'de primarykey olmasını sağlar order tabloların db' de sıralanması en üstte order = 1 olan diyerek gider.
        public int OrderId { get; set; }
        [Key,Column(Order=2)]
        public int ProductId { get; set; }
        [Column(TypeName ="int")]
        public short Quantity { get; set; }
        [Column(TypeName ="numeric(10,2)")]
        public decimal TotalPrice { get; set; }

        // Relational Property

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
