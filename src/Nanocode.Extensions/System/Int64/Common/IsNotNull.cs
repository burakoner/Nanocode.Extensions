using System;

namespace Nanocode.Extensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     A T extension method that query if '@this' is not null.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if not null, false if not.</returns>
        public static bool IsNotNull(this Int64? @this)
        {
            return @this != null;
        }
    }
}