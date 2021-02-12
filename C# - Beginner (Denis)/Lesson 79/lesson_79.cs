using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            Console.WriteLine(date1); // 01.01.0001 0:00:00

            Console.WriteLine(DateTime.MinValue);

            DateTime date = new DateTime(2015, 7, 20, 18, 30, 25); // год - месяц - день - час - минута - секунда
            Console.WriteLine(date1); // 20.07.2015 18:30:25

            Console.WriteLine(DateTime.Now);
            //20.07.2015 11:43:33

            Console.WriteLine(DateTime.UtcNow);
            //20.07.2015 8:43:33

            Console.WriteLine(DateTime.Today);
            //20.07.2015 0:00:00

            DateTime someDate = new DateTime(1582, 10, 5);
            Console.WriteLine(someDate.DayOfWeek);

            DateTime date11 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            Console.WriteLine(date1.AddHours(3)); // 20.07.2015 21:30:25

            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
            Console.WriteLine(date1.Subtract(date2)); // 03:00:00

            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25);
            Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
            Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
            Console.WriteLine(date1.ToLongDateString()); // 20 июля 2015 г.
            Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
            Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
            Console.WriteLine(date1.ToShortTimeString()); // 18:30

            DateTime now = DateTime.Now;
            Console.WriteLine("D: " + now.ToString("D"));
            Console.WriteLine("d: " + now.ToString("d"));
            Console.WriteLine("F: " + now.ToString("F"));
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));

        }
    }
}
