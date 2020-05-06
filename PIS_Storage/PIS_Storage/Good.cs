using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class Good
    {
        public int GoodId { get; set; }

        
        public int GoodTypeId { get; set; }

        [MinLength(5)]
        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        [Required]
        public short Price { get; set; }

        [MaxLength(400)]
        public string PhotoPath { get; set; }
    }
}
