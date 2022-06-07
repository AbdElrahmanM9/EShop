using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public DateTime AddedTime { get; set; }
        public string UserId { get; set; }
        public int ItemsId { get; set; }
        public Items Items { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPaid { get; set; }
        public int CartMasterId { get; set; }
        [ForeignKey("CartMasterId")]
        public CartMaster CartMaster { get; set; }
    }
}
