using Medict.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Viewmodels
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "Brand Name is required")]
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
        [Required(ErrorMessage = "Please choose image")]
        [Display(Name = "Profile Picture")]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        public double? Discount { get; set; }
       
        //public Product product { get; set; }
        //public IEnumerable<Category> Category { get; set; }
        //public IEnumerable<Brand> Brand { get; set; }
      
    }
}
