using EShop_Gp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class ItemsList
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Cart> carts { get; set; }
    }
}
