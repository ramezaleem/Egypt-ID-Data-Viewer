using System;
using System.Collections.Generic;
using System.Text;

namespace IDEgypt
{
    class Date : ID
    {
        string year;
        string month;
        string day;
        public void date ()
        {
            int intYear = int.Parse(id.Substring(0, 1)) + 17;
            year = intYear + id.Substring(1, 2);
            month = id.Substring(3, 2);
            day = id.Substring(5, 2);
            Console.WriteLine($"Your Date : {day}/{month}/{year}");
        }
    }
}