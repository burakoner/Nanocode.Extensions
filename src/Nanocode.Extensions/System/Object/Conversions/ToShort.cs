using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An object extension method that converts the @this to a short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a short.</returns>
        public static short ToShort(this object @this)
        {
            return Convert.ToInt16(@this);
        }
    }
}