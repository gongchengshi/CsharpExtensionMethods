namespace Treehouse.Common
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return (value % 2) == 0;
            //return (value & 1) == 0;
        }
    }
}
