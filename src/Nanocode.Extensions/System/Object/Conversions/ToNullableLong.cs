using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     An object extension method that converts the @this to a nullable long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a long?</returns>
        public static long? ToNullableLong(this object @this)
        {
            if (@this == null || @this == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt64(@this);
        }
    }
}