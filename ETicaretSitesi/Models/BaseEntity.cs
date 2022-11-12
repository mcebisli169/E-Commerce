using ETicaretSitesi.Enums;
using System;

namespace ETicaretSitesi.Models
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = RecordStatus.Active;
        }
        public int Id { get; set; }
        public int GroupCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public RecordStatus Status { get; set; }
        public string ModifiedUser { get; set; }

    }
}
