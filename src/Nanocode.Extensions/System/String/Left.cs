using System;

namespace Nanocode.Extensions.Strings
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A string extension method that return the left part of the string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="length">The length.</param>
        /// <returns>The left part.</returns>
        public static string Left(this string @this, int length)
        {
            return @this.Substring(0, Math.Min(length, @this.Length));
        }
    }
}