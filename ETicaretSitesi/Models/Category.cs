using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretSitesi.Models
{
    [Table("Category")]
    public class Category:BaseEntity
    {
        [Column("CategoryName", TypeName ="nvarchar(25)"),Required,MaxLength(20)]
        public string CategoryName { get; set; }
        [Column("Description", TypeName ="nvarchar(250)")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
