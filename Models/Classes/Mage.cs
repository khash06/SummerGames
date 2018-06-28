using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Mage : Player
    {
        public Mage(string NewName)
        {
            Class = "Mage";
            intelligence = 35;
            health = 250;
            healthMax = 250;
        }
        public void Attack(Enemies name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1 * intelligence, 3 * intelligence);
            name1.health = name1.health - attack;
        }
        public void heal()
        {
            Random rand = new Random();
            int light_heal = rand.Next(5 * intelligence, 10 * intelligence);
            health += light_heal;
        }
        public void fireball(Enemies name1)
        {
            Random rand = new Random();
            int Fire_ball = rand.Next(2 * intelligence, 8 * intelligence);
            name1.health = name1.health - Fire_ball;
        }
        public void FrostBoil(Enemies name1)
        {
            Random rand = new Random();
            int Frost_Boil = rand.Next(4 * intelligence, 6 * intelligence);
            name1.health = name1.health - Frost_Boil;
        }
    }
}