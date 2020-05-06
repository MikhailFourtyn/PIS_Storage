using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PIS_Storage
{
    public class Storage
    {
        public int StorageId { get; set; }

        [Required]
        public int GoodId {get; set;}

        [Required]
        public short Amount { get; set; }
    }
}
