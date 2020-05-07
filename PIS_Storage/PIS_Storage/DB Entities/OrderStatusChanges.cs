using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class OrderStatusChange
    {
        public int OrderStatusChangeId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public byte OrderStatus { get; set; }

        //public DateTime Timestamp { get; set; }
        // Уточнить тип данных
    }
}
