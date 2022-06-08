using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime AddedTime { get; set; }
        public string IsPaid { get; set; }
        public string UserPhoneNum { get; set; }
    }
}
