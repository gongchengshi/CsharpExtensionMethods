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
                "ideal"
            };

            Console.WriteLine($"My dog Jojo is the {ListUtils.RandomItem(synonymsForBest)} dog!");
            Console.ReadLine();
        }
    }
}
