using EShop_Gp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class PopUp
    {
        public IEnumerable<Product> products { get; set; }
        public List<Items> Items { get; set; }
        public IEnumerable<Cart> carts { get; set; }
        public int UserId { get; set; }
        public decimal SumPrice { get; set; }
        public DateTime DayOfReceipt { get; set; }
        public List<int> CartIds { get; set; }
    }
}
