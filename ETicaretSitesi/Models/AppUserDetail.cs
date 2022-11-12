namespace ETicaretSitesi.Models
{
    public class AppUserDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int AppUserID { get; set; }

        // Relational property

        public AppUser AppUser { get; set; }
    }
}
