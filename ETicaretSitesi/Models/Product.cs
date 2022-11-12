using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretSitesi.Models
{
    [Table("Product")]
    public class Product:BaseEntity
    {
        [Column("ProductName", TypeName = "nvarchar(50)")]
        [Required] // zorunlu alan productname olmadan yeni alan açılamaz
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "int"),Required]
        public decimal UnitPrice { get; set; }
        [Column("UnitsInStock", TypeName ="int")]
        public short UnitsInStock { get; set; }
        [Column("CategoryId", TypeName ="int"),Required]
        public int CategoryId { get; set; }
    
        // Relational Property

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
