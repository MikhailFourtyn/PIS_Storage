using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class GoodType
    {
        public int GoodTypeId { get; set; }
        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public ICollection<Good> Goods { get; set; }
        public GoodType()
        {
            Goods = new List<Good>();
        }
    }
}
