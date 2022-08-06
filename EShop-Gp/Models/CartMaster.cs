using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class CartMaster
    {
        [Key]
        public int Id { get; set; }
        public DateTime? OrderTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsPaid { get; set; }
        public string UserId { get; set; }
    }
}
