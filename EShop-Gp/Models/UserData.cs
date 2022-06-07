using Microsoft.AspNetCore.Identity;

namespace EShop_Gp.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string BuildingNameOrNum { get; set; }
        public string CityAndArea { get; set; }
        public string NearestToken { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public bool IsCash { get; set; }
        public bool IsCreditCard { get; set; }
        public int? CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
