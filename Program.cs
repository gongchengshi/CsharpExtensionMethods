using System;
using System.Collections.Generic;
using Treehouse.Common;

namespace Treehouse
{
    class Program
    {
        public static void Main()
        {
            int num = 5;
            if(num.IsEven())
            {
                
            }

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

            Console.WriteLine($"My dog Jojo is the {synonymsForBest.RandomItem()} dog!");
            Console.ReadLine();
        }
    }
}
