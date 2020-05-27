using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] insults = {
                   "You look like what morning breath smells like.",
                    "If you tried to give me cpr I would probably throw myself back under water",
                    "I am not a fan of you",
                    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                    "I'd rather walk than be on the same plane as you",
                    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                    "Do you have to be so...like that?"
            };

            Random random = new Random();
            List<int> indicies = new List<int>();
            int[] indiciesArray = indicies.ToArray();

            while (indiciesArray.Length < 3)
            {
                int insult = random.Next(0, insults.Length - 1);


                foreach (int index in indicies)
                {
                    if (insult != index)
                    {
                        // indicies.push(insult)
                    }
                }
            }

            for (int i = 0; i < indiciesArray.Length; i++)
            {
                int currentIndex = indicies[i];
                Console.WriteLine(insults[currentIndex]);
            }





            Console.WriteLine("Hello World!");
        }
    }
}
