using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SummerGames.Models;

namespace SummerGames.Models
{
    public class Story
    {
        public int StoryId { get; set; }
        public string Storybook { get; set; }
        public DateTime created_at { get; set; }
    }
}