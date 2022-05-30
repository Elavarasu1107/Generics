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

            new MaxFinder<int>(100, 75, 50, 250, 650).Display();
            new MaxFinder<float>(100.5464F, 75.5644F, 50.5478F, 125.5556F, 85.5456F).Display();
            new MaxFinder<string>("Apple", "Banana", "Orange", "Grapes", "Mango").Display();
        }
    }
}
