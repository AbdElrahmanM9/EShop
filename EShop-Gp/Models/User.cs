using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop_Gp.Models
{
    public class User : IdentityUser
    {
        public string Type { get; set; }
    }
}
