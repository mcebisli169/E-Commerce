using ETicaretSitesi.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretSitesi.Models
{
    public class AppUser:BaseEntity
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped] // repassword alanını db'de kolon olarak açılmamasını belirtildi.
        public string RePassword { get; set; }
        public Role Role { get; set; }

        // Relational Property

        public virtual AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
