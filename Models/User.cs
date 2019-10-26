using System;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class User
    {
        [Required]
        [StringLength(10)]        
        public String username { get; set; }

        [Required]
        [StringLength(10)]
        public String password { get; set; }
    }
}
