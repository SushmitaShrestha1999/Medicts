using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Created Date")]
        public DateTime? CreatedDate { get; set; }

        public List<Product> Product { get; set; }
    }
}
