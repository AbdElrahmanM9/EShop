using Microsoft.AspNetCore.Identity;

namespace EShop_Gp.ViewModel
{
    public class UserDataViewModel
    {
        public int Id { get; set; } = 0;
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string BuildingNameOrNum { get; set; }
        public string CityAndArea { get; set; }
        public string NearestToken { get; set; }

        public string UserId { get; set; } = "";
        public IdentityUser User { get; set; } 
    }
}
