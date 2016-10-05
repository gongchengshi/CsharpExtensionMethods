namespace Treehouse.Common
{
    public static class ExtensionMethods
    {
        public static bool IsDefault<T>(this T @this)
        {
            return @this.Equals(default(T));
        }
    }
}
