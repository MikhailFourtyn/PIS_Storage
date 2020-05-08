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
        public Order Order { get; set; }
        public override string ToString()
        {
            switch(OrderStatus)
            {
                case 0:
                    return "Оформлен";
                case 1:
                    return "Упакован";
                case 2:
                    return "Отправлен на доставку";
                case 3:
                    return "Доставлен";
                default:
                    return "";
            }
        }
    }
}
