using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
        public int? categoryid { get; set; }
    }
}
