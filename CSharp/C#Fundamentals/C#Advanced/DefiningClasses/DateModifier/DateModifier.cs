using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int CalculateDaysDifference (string firstDate, string secondDate)
        {
            return (int)(DateTime.Parse(firstDate) -DateTime.Parse(secondDate)).TotalDays;
        }
    }
}
