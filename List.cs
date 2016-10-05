using System;

namespace Treehouse
{
    public class List<T> : System.Collections.Generic.List<T>
    {
        public List()
        {
        }

        public List(int capacity) : base(capacity)
        {
        }

        private static readonly Random _random = new Random();

        public T RandomItem()
        {
            return this[_random.Next(0, Count)];
        }
    }
}
