using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Dragon : Enemies
    {   
        
        public Dragon()
        {
            name = "Dragon";
            strength = 10;
            health = 300;
            healthMax = 300;
        }
        public void RandomDragonAttack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1,6);
            if(attack == 1)
            {
                this.Attack(name1);
            }
            if(attack == 2)
            {
                this.FireBreath(name1);
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
            int attack = rand.Next(3 * strength, 5 * strength);
            name1.health = name1.health - attack;
        }
        public void FireBreath(Player name1)
        {
            Random rand = new Random();
            int firebreath = rand.Next(9 * strength, 13 * strength);
            name1.health = name1.health - firebreath;
        }
    }
}