using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiquorAdda.Core.Models
{
    public class Liquor
    {
        [Key]
        public int LiquorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string LiquorName { get; set; }

        [Required]
        public double LiquorPrice { get; set; }

        [Required]
        public double LiquorQuantity { get; set; }

        public string LiquorType { get; set; }
    }
}
