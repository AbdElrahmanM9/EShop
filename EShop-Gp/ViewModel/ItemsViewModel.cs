using EShop_Gp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.ViewModel
{
    public class ItemsViewModel
    {
        public List<Items> Items { get; set; }
        public string SearchString { get; set; }
    }
}
