using System;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mydate = new DateTime(2021, 8, 4, 23, 58, 30, 999);

            var timestamp = mydate.ToString("ddMMyyyy");


            //day formats
            Console.WriteLine("\"d\" -> {0}", mydate.ToString("d"));
            Console.WriteLine("\"d/M/yy\" -> {0}", mydate.ToString("d/M/yy"));
            Console.WriteLine("\"dd\" -> {0}", mydate.ToString("dd"));
            Console.WriteLine("\"ddd\" -> {0}", mydate.ToString("ddd"));
            Console.WriteLine("\"dddd\" -> {0}", mydate.ToString("dddd"));
            //month formats
            Console.WriteLine("\"M\" -> {0}", mydate.ToString("M"));
            Console.WriteLine("\"d/M/yy\" -> {0}", mydate.ToString("d/M/yy"));
            Console.WriteLine("\"MM\" -> {0}", mydate.ToString("MM"));
            Console.WriteLine("\"MMm\" -> {0}", mydate.ToString("MMM"));
            Console.WriteLine("\"MMMM\" -> {0}", mydate.ToString("MMMM"));
            //year formats
            Console.WriteLine("\"y\" -> {0}", mydate.ToString("y"));
            Console.WriteLine("\"yy\" -> {0}", mydate.ToString("yy"));
            Console.WriteLine("\"yyy\" -> {0}", mydate.ToString("yyy"));
            Console.WriteLine("\"yyyy\" -> {0}", mydate.ToString("yyyy"));
            Console.WriteLine("\"yyyyy\" -> {0}", mydate.ToString("yyyyy"));
            //hour formats
            Console.WriteLine("\"mm/dd/yy h\" -> {0}", mydate.ToString("MM/dd/yy h"));
            Console.WriteLine("\"hh\" -> {0}", mydate.ToString("hh"));
            Console.WriteLine("\"mm/dd/yy h\" -> {0}", mydate.ToString("MM/dd/yy H"));
            Console.WriteLine("\"HH\" -> {0}", mydate.ToString("HH"));
            //minuts formats
            Console.WriteLine("\"m\" -> {0}", mydate.ToString("m"));
            Console.WriteLine("\"mm\" -> {0}", mydate.ToString("mm"));
            Console.WriteLine("\"h:m\" -> {0}", mydate.ToString("h:m"));
            Console.WriteLine("\"hh:mm\" -> {0}", mydate.ToString("hh:mm"));
            //second formats
            Console.WriteLine("\"s\" -> {0}", mydate.ToString("s"));
            Console.WriteLine("\"ss\" -> {0}", mydate.ToString("ss"));
            //AM/PM
            Console.WriteLine("\"hh:mm t\" -> {0}", mydate.ToString("hh:mm t"));
            Console.WriteLine("\"hh:mm tt\" -> {0}", mydate.ToString("hh:mm tt"));
            //timezone formats
            Console.WriteLine("\"mm/dd/yy K\" -> {0}", mydate.ToString("MM/dd/yy K"));
            Console.WriteLine("\"mm/dd/yy z\" -> {0}", mydate.ToString("MM/dd/yy z"));
            Console.WriteLine("\"zz\" -> {0}", mydate.ToString("zz"));
            Console.WriteLine("\"zzz\" -> {0}", mydate.ToString("zzz"));
        }
    }
}
