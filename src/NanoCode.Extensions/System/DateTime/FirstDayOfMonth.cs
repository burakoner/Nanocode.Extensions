using System;

namespace NanoCode.Extensions
{
    public static partial class ExtensionMethods
    {
        public static DateTime FirstDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }
    }
}