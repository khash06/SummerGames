using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Samurai : Player
    {
        public Samurai()
        {
            Class = "Samurai";
            strength = 35;
            health = 300;
            healthMax = 300;
        }
        public void Attack(Enemies name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1 * strength, 3 * strength);
            name1.health = name1.health - attack;
        }
        public void Meditate()
        {
            Random rand = new Random();
            int meditate = rand.Next(5 * strength, 10 * strength);
            health += meditate;
        }
        public void Smash(Enemies name1)
        {
            Random rand = new Random();
            int smash = rand.Next(4 * strength, 6 * strength);
            name1.health = name1.health - smash;
        }
        public void Death_Blow(Enemies name1)
        {
            Random rand = new Random();
            int Death_Blow = rand.Next(3 * strength, 8 * strength);
            name1.health = name1.health - Death_Blow;
        }
    }
}