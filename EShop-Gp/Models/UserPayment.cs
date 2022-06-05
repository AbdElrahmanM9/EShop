using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class UserPayment
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string NameOnTheCard { get; set; }

        public bool IsCash { get; set; }
        public bool IsVisa { get; set; }
        public bool IsPayPal { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
