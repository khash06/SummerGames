using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SummerGames.Models;
namespace SummerGames.Models
{
public class Encounters
    {
        public int EncountersId { get; set; }
        public string Story  { get; set;} 
        public int spiders { get; set;}
        public int zombies { get; set;}
        public int orcs { get; set; }
        public int dragons { get; set;}       
        public Player Player {get;set;}
        public int PlayerId{get;set;}
        List <Multiplayer> MorePlayers{get; set;}
        List<Enemies> FightEnemies { get; set; }

        public Encounters()
        {
            MorePlayers = new List <Multiplayer>();
            FightEnemies = new List <Enemies>();
        } 
        public Player Death(Player dead)
        {
            Player.health = 0;
            Player.Life = false;
            return(dead);
        }
    }
        public class Levels : Encounters
        {
        public int LevelsId {get;set;}
        public int Level {get;set;} = 1;
        public int temp {get;set;} = 200;
        }   
}
