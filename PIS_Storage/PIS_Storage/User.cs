using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class User
    {
        public int UserId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        
        [MinLength(5)]
        [MaxLength(20)]
        [Required]
        public string Login { get; set; }

        [MinLength(5)] 
        [MaxLength(20)]
        [Required]
        public string Password { get; set; }

        [Required]
        public byte Status { get; set; }
    }
}
