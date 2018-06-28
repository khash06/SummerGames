using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Priest : Player
    {
        public Priest(string NewName)
        {
            Class = "Priest";
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
        public void Holy_Heal()//heal
        {
            Random rand = new Random();
            int Mend = rand.Next(7 * intelligence, 12 * intelligence);
        }
        public void Holy_Light(Enemies name1)
        {
            Random rand = new Random();
            int holy_light = rand.Next(2 * intelligence, 6 * intelligence);
            name1.health = name1.health - holy_light;
        }
        public void Smight(Enemies name1)
        {
            Random rand = new Random();
            int smight = rand.Next(3 * intelligence, 5 * intelligence);
            name1.health = name1.health - smight;
        }
    }
}