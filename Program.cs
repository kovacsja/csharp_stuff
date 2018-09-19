using System;
using System.Linq;

namespace c_sharp_date_goodies
{
    class Program
    {

		static void Main(string[] args)
        {
            DateTime dateToConvert = DateTime.Now;
            Console.WriteLine("Hello World!");
            Console.WriteLine(dateToConvert);
            string datetext = DateTime.Now.ToShortDateString();
            System.Console.WriteLine(datetext + DateTime.Now.ToShortTimeString());
        }
    }
}
