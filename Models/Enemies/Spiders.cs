using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Spider : Enemies
    {   
        public Spider()
        {
            strength = 10;
            health = 150;
            healthMax = 150;
        }
        public void spider_attack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1,6);
            if(attack == 1)
            {
                this.Attack(name1);
            }
            if(attack == 2)
            {
                this.Spin_Web(name1);
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
        public void Spin_Web(Player name1)
        {
            Random rand = new Random();
            int spin_web = rand.Next(4 * strength, 7 * strength);
            name1.health = name1.health - spin_web;
        }
    }
}