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
            var forInt = getMethod.ValueCheck(100, 75, 50);
            Console.WriteLine("The Maximum Value is: "+forInt);
        }
    }
}
