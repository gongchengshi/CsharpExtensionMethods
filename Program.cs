using System;
using System.Collections.Generic;

namespace Treehouse
{
    class Program
    {
        public static void Main()
        {
            var synonymsForBest = new List<string>
            {
                "best",
                "finest",
                "greatest",
                "top",
                "foremost",
                "leading",
                "most excellent",
                "preeminent",
                "premier",
                "chief",
                "supreme",
                "unrivaled",
                "ultimate",
                "perfect",
                "incomparable",
                "ideal"
            };

            var random = new Random();
            var best = synonymsForBest[random.Next(0, synonymsForBest.Count -1)];

            Console.WriteLine($"My dog Jojo is the {best} dog!");
        }
    }
}
