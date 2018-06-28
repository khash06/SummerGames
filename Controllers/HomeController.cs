using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SummerGames.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SummerGames.Controllers
{
    public class HomeController : Controller
    {
        
        private SummerContext _context;

        public HomeController(SummerContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult firstEncounter(Player Player1, int Level)
        {
            List<Enemies> enemy = new List<Enemies>();
            string storyline ="";
            if(Level == 1)
            {
                storyline = "On a hot summer day at the Dojo..........The Dojo's AC which is on the top floor, was destroyed by the Summer Dragon God";
            }
            else if (Level == 2)
            {
                storyline = "Climbed the stairs to the Second Floor as the temperature continues to rise. ";
            }
            else if (Level == 3)
            {
                storyline = "You have reached the third floor. You hear the sound of ping pong balls being smashed. You resist the temptation. The Summer Dragon God appears.......He looks angry. ";
            }
            if(Level == 3)
            {
                Encounters bossEcounter = new Encounters();
                bossEcounter.PlayerId = Player1.PlayerId;
                bossEcounter.dragons = 1;
                bossEcounter.Story = storyline;
                _context.Add(bossEcounter);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("EncounterId", bossEcounter.EncountersId);
                for(var i = 0; i< bossEcounter.dragons;i++)
                {   
                    Dragon newDragon = new Dragon();
                    newDragon.EncountersId = newDragon.EncountersId;
                    _context.Add(newDragon);
                }
            }
            else
            {
                Encounters newEcounter = new Encounters();
                newEcounter.PlayerId = Player1.PlayerId;
                newEcounter.Story = storyline;
                newEcounter.spiders = 2 * Level;
                newEcounter.zombies = 2 * Level;
                newEcounter.orcs = 1 * Level;
                _context.Add(newEcounter);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("EncounterId", newEcounter.EncountersId);
                for(var i = 0; i< newEcounter.spiders;i++)
                {       Zombie newZomb = new Zombie();
                        newZomb.EncountersId = newEcounter.EncountersId;
                        Spider newSpid = new Spider();
                        newSpid.EncountersId = newEcounter.EncountersId;
                        _context.Add(newZomb);
                        _context.Add(newSpid);
                        _context.SaveChanges();
                }
                for(var i = 0; i< newEcounter.orcs;i++)
                {
                    Orc newOrc = new Orc();
                    newOrc.EncountersId = newEcounter.EncountersId;
                    _context.Add(newOrc);
                }
                }
                HttpContext.Session.SetObjectAsJson("Enemies", enemy);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        // public IActionResult PlayersTurn(Player Player1, Enemies Enemy)
        // {
            
        // }
    }
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
