using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        IRiddleRepo repo;
        public HomeController(IRiddleRepo r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Writing()
        {
            return View();
        }
        public IActionResult Photography()
        {
            return View();
        }
        public IActionResult Programming()
        {
            List<Riddle> riddles = repo.Riddles;
            return View(riddles);
        }
        [HttpPost]
        public IActionResult Programming(string playerName)
        {
            Player player = new Player();
            player.PlayerName = playerName;

            List<Riddle> riddles = repo.Riddles;
            return View(riddles);
        }
        public IActionResult Contact()
        {
            return View();
        }



    }
}
