using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        public string Name { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; } 

        [Display(Name = "Short Description")]
        public string ShotrtDescription { get; set; }

        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
       
        public int Quantity { get; set; }
      
        public string Image { get; set; }
        [Required (ErrorMessage ="Price is required")]
        public double Price { get; set; }
        public double? Discount { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }

    }

}
