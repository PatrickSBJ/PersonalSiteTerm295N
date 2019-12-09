using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class PlayerRepo
    {
        private AppDbContext context;

        public List<Player> Players { get { return context.Players.ToList(); } }

        public PlayerRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public  void AddPlayer(Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }


    }
}
