using System;
using System.Linq;

namespace c_sharp_date_goodies
{
    class Program
    {
		static void Main(string[] args)
        {
            System.Console.WriteLine(NowToPostFix());
            System.Console.WriteLine(DateToPostFix());
        }

        static string NowToPostFix () {
            string YearPart = Convert.ToString(DateTime.Now.Year);
            string MonthPart = "0" + Convert.ToString(DateTime.Now.Month);
            string DayPart = "0" + Convert.ToString(DateTime.Now.Day);
            string HourPart = "0" + Convert.ToString(DateTime.Now.Hour);
            string MinPart = "0" + Convert.ToString(DateTime.Now.Minute);

            return YearPart + MonthPart.Substring(MonthPart.Length - 2) + DayPart.Substring(DayPart.Length -2) + HourPart.Substring(HourPart.Length -2) + MinPart.Substring(MinPart.Length -2);
        }
        static string DateToPostFix() {
            string YearPart = Convert.ToString(DateTime.Now.Year);
            string MonthPart = "0" + Convert.ToString(DateTime.Now.Month);
            string DayPart = "0" + Convert.ToString(DateTime.Now.Day);

            return YearPart + MonthPart.Substring(MonthPart.Length - 2) + DayPart.Substring(DayPart.Length -2);

        }
    }
}
