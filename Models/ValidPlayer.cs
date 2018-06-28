using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SummerGames.Models
{
    public class ValidPlayer
    {
        public int PlayerId { get; set; }
        [Required(ErrorMessage="Pick a username")]
        public string Username { get; set; }
        [Required(ErrorMessage="Pick a password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string confirmPassword { get; set; }
    }
}