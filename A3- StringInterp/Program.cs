// See https://aka.ms/new-console-template for more information

using System;

namespace StringInterp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            
            const int nameAlign = 40;
            const int nameAlign1 = 10;
        Console.WriteLine($"|{date,nameAlign:MMMM d, yyyy}|");
        Console.WriteLine($"|{date:yyyy.mm.dd}|");
        Console.WriteLine($"|Day {date:dd,} of {date:MMMM, yyyy}|");
        Console.WriteLine($"|Year: {date:yyyy,} Month: {date:mm,} Day: {date:dd}|");
        Console.WriteLine($"|{date.DayOfWeek, nameAlign1}|");
        Console.WriteLine($"|{date,nameAlign1:hh:mm}{ date.DayOfWeek,nameAlign1}|");
        Console.WriteLine($"|h: {date:hh,} m: {date:mm,} s: {date:ss}|");
        Console.WriteLine($"|{date:yyyy.mm.dd.hh.mm.ss}|");

        const int nameAlignPI = 7;
        var PI = Math.PI;
        Console.WriteLine($"{PI,nameAlignPI:C3}|");
        Console.WriteLine($"{Math.PI,nameAlignPI:F3}|");












        }
    }
}