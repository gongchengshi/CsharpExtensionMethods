using System;
using System.Linq;
using System.Collections.Generic;

namespace Treehouse.Linq
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            if(@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return !@this.Any();
        }
    }
}
