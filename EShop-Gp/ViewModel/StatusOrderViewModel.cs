using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class StatusOrderViewModel
    {
        public string OrderTimeOfReceipt { get; set; }
        public int ItemId { get; set; }
        public String NameAr { get; set; }
        public String NameEn { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
