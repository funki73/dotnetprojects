using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //...all womens' leagues
            ViewBag.WomensLeagues = _context.Leagues.Where(l => l.Name.Contains("Women")).ToList();
            //...all leagues where sport is any type of hockey
            ViewBag.HockeyLeagues = _context.Leagues.Where(l => l.Name.Contains("Hockey")).ToList();
            //...all leagues where sport is something OTHER THAN football
            ViewBag.NonFootballLeagues = _context.Leagues.Where(l => !l.Name.Contains("Football")).ToList();
            //...all leagues that call themselves "conferences"
            ViewBag.Conferences = _context.Leagues.Where(l => l.Name.Contains("Conference")).ToList();
            //...all leagues in the Atlantic region
            ViewBag.AtlanticRegion = _context.Leagues.Where(l => l.Name.Contains("Atlantic")).ToList();
            //...all teams based in Dallas
            ViewBag.DallasTeams = _context.Teams.Where(t => t.Location.Contains("Dallas")).ToList();
            //...all teams named the Raptors
            ViewBag.TeamRaptor = _context.Teams.Where(t => t.TeamName.Contains("Raptors")).ToList();
            //...all teams whose location includes "City"
            ViewBag.TeamswithCity = _context.Teams.Where(t => t.Location.Contains("City")).ToList();
            //...all teams whose names begin with "T"
            ViewBag.TeamswithcapT = _context.Teams.Where(t => t.TeamName.Contains("T")).ToList();
            //...all teams, ordered alphabetically by location
            ViewBag.TeamsOrdLoc = _context.Teams.OrderBy(t => t.Location).ToList();
            //...all teams, ordered by team name in reverse alphabetical order
            ViewBag.TeamsOrdNamRev = _context.Teams.OrderByDescending(t => t.TeamName).ToList();
            //...every player with last name "Cooper"
            ViewBag.LastNameCooper = _context.Players.Where(t => t.LastName.Contains("Cooper")).ToList();
            //...every player with first name "Joshua"
            ViewBag.FirstNameJoshua = _context.Players.Where(t => t.FirstName.Contains("Joshua")).ToList();
            //...every player with last name "Cooper" EXCEPT those with "Joshua" as the first name
            ViewBag.LastNameCooperexceptJoshua = _context.Players.Where(t => t.LastName.Contains("Cooper") && !t.FirstName.Contains("Joshua")).ToList();
            //...all players with first name "Alexander" OR first name "Wyatt"
            ViewBag.FirstNameAlexanderWyatt = _context.Players.Where(t => t.FirstName.Contains("Joshua") || t.FirstName.Contains("Wyatt")).ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}