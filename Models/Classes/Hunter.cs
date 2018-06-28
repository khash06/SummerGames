using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Hunter : Player
    {   
        public Hunter()
        {
            Class = "Hunter";
            dexterity = 35;
            health = 270;
            healthMax = 270;
        }
        public void Attack(Enemies name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1 * dexterity, 3 * dexterity);
            name1.health = name1.health - attack;
        }
        public void Mend()//heal
        {
            Random rand = new Random();
            int mend = rand.Next(3* dexterity, 6 * dexterity);
            health += mend;
        }
        public void Snipe(Enemies name1)
        {
            Random rand = new Random();
            int snipe = rand.Next(2 * dexterity, 10 * dexterity);
            name1.health = name1.health - snipe;
        }
        public void Silencing_Shot(Enemies name1)
        {
            Random rand = new Random();
            int silencing_shot = rand.Next(3 * dexterity, 5 * dexterity);
            name1.health = name1.health - silencing_shot;
        }
    }
}