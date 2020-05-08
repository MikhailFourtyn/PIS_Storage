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

        /*
         * Перечень статусов:
         * 0 - Пользователь;
         * 1 - Менеджер;
         * 2 - Администратор
         */
        [Required]
        public byte Status 
        { 
            get; 
            set;
        }

        public ICollection<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }
        public override string ToString()
        {
            return Name;
        }

        public string StatusToString()
        {
            switch(Status)
            {
                case 0:
                    return "Пользователь";
                case 1:
                    return "Менеджер";
                case 2:
                    return "Администратор";
                default:
                    return "Пользователь";
            }
        }
    }
}
