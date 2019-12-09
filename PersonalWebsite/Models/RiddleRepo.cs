using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class RiddleRepo : IRiddleRepo
    {
        private AppDbContext context;

        public List<Riddle> Riddles { get { return context.Riddles.ToList(); } }

        public RiddleRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public  void AddRiddle(Riddle riddle)
        {
            context.Riddles.Add(riddle);
            context.SaveChanges();
        }

    }
}
