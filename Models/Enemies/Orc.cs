using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Orc : Enemies
    {   
        public Orc()
        {
            strength = 10;
            health = 200;
            healthMax = 200;
        }
        public void Orc_attack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1,6);
            if(attack == 1)
            {
                this.Attack(name1);
            }
            if(attack == 2)
            {
                this.Club_Bash(name1);
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
        public void Club_Bash(Player name1)
        {
            Random rand = new Random();
            int club_bash = rand.Next(7 * strength, 10 * strength);
            name1.health = name1.health - club_bash;
        }
    }
}