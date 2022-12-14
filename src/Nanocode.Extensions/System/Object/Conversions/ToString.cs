using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An object extension method that convert this object into a string representation.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A string that represents this object.</returns>
        public static string ToString(this object @this)
        {
            return Convert.ToString(@this);
        }
    }
}