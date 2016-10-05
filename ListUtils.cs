using System;
using System.Collections.Generic;

namespace Treehouse
{
    public static class ListUtils
    {
        private static readonly Random _random = new Random();

        public static T RandomItem<T>(List<T> list)
        {
            return list[_random.Next(0, list.Count)];
        }
    }
}
