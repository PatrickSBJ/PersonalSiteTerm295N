using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public interface IRiddleRepo
    {
        List<Riddle> Riddles { get; }

        void AddRiddle(Riddle riddle);

    }
}
