using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Zombie : Enemies
    {   
        public Zombie()
        {
            strength = 10;
            health = 100;
            healthMax = 100;
        }
        public void Zombie_attack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1,6);
            if(attack == 1)
            {
                this.Attack(name1);
            }
            if(attack == 2)
            {
                this.Bite(name1);
            }
            if(attack == 3)
            {
                this.Attack(name1);
            }
            if(attack == 4)
            {
                this.Attack(name1);
            }
            if(attack == 5)
            {
                this.Attack(name1);
            }
        }
        public void Attack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1 * strength, 3 * strength);
            name1.health = name1.health - attack;
        }
        public void Bite(Player name1)
        {
            Random rand = new Random();
            int bite = rand.Next(7 * strength, 10 * strength);
            name1.health = name1.health - bite;
        }
    }
}