using System;

namespace Nanocode.Extensions.Objects
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        ///     Gets the types of the objects in the specified array.
        /// </summary>
        /// <param name="args">An array of objects whose types to determine.</param>
        /// <returns>An array of  objects representing the types of the corresponding elements in .</returns>
        public static Type[] GetTypeArray(this object[] args)
        {
            return Type.GetTypeArray(args);
        }
    }
}