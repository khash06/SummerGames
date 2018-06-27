using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SummerGames.Models
{
    public class ValidPlayer
    {
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}