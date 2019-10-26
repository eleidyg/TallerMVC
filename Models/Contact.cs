using System;
using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Contact
    {

    public Contact(String id,String name,String address,String email) 
    { 
        this.id=id;
        this.name=name;
        this.address=address;
        this.email=email;
    } 

        [Required]
        [StringLength(10)]        
        public String id { get; set; }
        [Required]
        [StringLength(10)]        
        public String name { get; set; }

        [Required]
        [StringLength(100)]
        public String address { get; set; }

        [Required]
        [StringLength(10)]
        [EmailAddress]
        public String email { get; set; }
    }
}
