using System;

namespace Treehouse.Common
{
    public static class StringExtensions
    {
        public static string[] Split(this string @this, char delimiter, int max)
        {
            if(@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this.Split(new[] { delimiter }, max);
        }
    }
}
