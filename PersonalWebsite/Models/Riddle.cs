using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class Riddle
    {
        public int RiddleID { get; set; }
        public string RiddleText { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
