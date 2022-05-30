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

            MaxFinder<int> intMethod = new MaxFinder<int>(100, 75, 50, 250,650);
            Console.WriteLine("The Maximum Integer Value is: " + intMethod.ValueCheck());
            MaxFinder<float> floatMethod = new MaxFinder<float>(100.5464F, 75.5644F, 50.5478F, 125.5556F, 85.5456F);
            Console.WriteLine("The Maximum Float Value is: " + floatMethod.ValueCheck());
            MaxFinder<string> stringMethod = new MaxFinder<string>("Apple", "Banana", "Orange", "Grapes", "Mango");
            Console.WriteLine("The Maximum String Value is: " + stringMethod.ValueCheck());
        }
    }
}
