using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An object extension method that converts the @this to an u int 32.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as an uint.</returns>
        public static uint ToUInt32(this object @this)
        {
            return Convert.ToUInt32(@this);
        }
    }
}