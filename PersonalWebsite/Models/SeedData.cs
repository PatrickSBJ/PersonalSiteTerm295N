using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Models
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Riddles.Any())
            {
                Riddle riddle = new Riddle()
                {
                    RiddleText = "How can you make six into an odd number?",
                    CorrectAnswer = "Remove the letter S and you have IX",
                };
                context.Riddles.Add(riddle);

                Riddle riddle1 = new Riddle()
                {
                    RiddleText = "I have keys but no locks. I have a space but no room. You can enter, but can’t go outside.",
                    CorrectAnswer = "Keyboard",
                };
                context.Riddles.Add(riddle1);

                Riddle riddle2 = new Riddle()
                {
                    RiddleText = "I can only live where there is light, but I die if the light shines on me.",
                    CorrectAnswer = "A shadow",
                };
                context.Riddles.Add(riddle2);


                context.SaveChanges(); // save all the data
            }
        }
    }
}
