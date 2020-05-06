using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }

        [Required]
        public int GoodId { get; set; }
        
        [Required]
        public int UserId { get; set; }

        [Required]
        public short Amount { get; set; }

        [Required]
        public int OrderStatusChangesId { get; set; }
    }
}
