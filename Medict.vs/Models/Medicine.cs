using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }
        [Required]
        [Display(Name = "Medicine name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Manufactured By")]
        public string CompanyName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Manufactured Date")]
        public DateTime Dateofmanufactured { get; set; }
        [Required]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
