using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Running Generics Program");

            MaxFinder getMethod = new MaxFinder();
            var forInt = getMethod.ValueCheck<int>(100, 75, 50);
            var forFloat = getMethod.ValueCheck<float>(75.2584F, 150.2205F, 50.6584F);
            var forString = getMethod.ValueCheck<string>("Apple", "Peach", "Banana");
            Console.WriteLine("The Maximum Integer Value is: "+forInt);
            Console.WriteLine("The Maximum Float Value is: " + forFloat);
            Console.WriteLine("The Maximum String Value is: " + forString);
        }
    }
}
