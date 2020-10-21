using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required (ErrorMessage ="Brand Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Created Date")]
        public DateTime? CreatedDate { get; set; }

        public List<Product> Product { get; set; }
    }
}
