using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public short Amount { get; set; }

        public GoodType GoodType { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Good()
        {
            Orders = new List<Order>();
        }
        //public Storage Storage { get; set; }
    }
}
