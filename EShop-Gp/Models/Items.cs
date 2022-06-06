using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class Items
    {
        public int Id { get; set; }
        public String NameAr { get; set; }
        public String NameEn { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal PriceAfterDiscount { get; set; }
        public decimal Price { get; set; }
        public decimal PriceCost { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool FlagRequest { get; set; }
        public int AddToCart { get; set; }
        public bool sold { get; set; }
        public int? Evaluation { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
