using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class RoleModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}