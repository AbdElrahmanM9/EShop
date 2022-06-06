using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class ItemsModel
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceCost { get; set; }
        public IFormFile Image { get; set; }
        public string Description { get; set; }
        public int? ProductId { get; set; }
    }
}
