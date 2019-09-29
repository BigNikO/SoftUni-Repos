using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static long GetDaysBetweenTowDates(string firstDateString, string secondDateString)
        {
            DateTime firstDate = DateTime.ParseExact(firstDateString, "yyyy MM dd", CultureInfo.InvariantCulture);   
            DateTime secondDate = DateTime.ParseExact(secondDateString, "yyyy MM dd", CultureInfo.InvariantCulture);

            return Math.Abs((firstDate - secondDate).Days);
        }
    }
}
