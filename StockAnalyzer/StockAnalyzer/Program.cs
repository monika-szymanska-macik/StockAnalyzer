﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"StockData.csv");
            foreach(var line in lines.Skip(1))
            {
                var segments = line.Split(",");
                var tradeDate = DateTime.Parse(segments[1]);
                Console.WriteLine(tradeDate.ToLongDateString());
            }
        }
    }
}
