using System;

namespace Generics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Running Generics Program");

            int[] integer = { 1, 2, 3, 4, 5 };
            double[] doubles = { 1.1, 1.2, 1.3, 1.4, 1.5 };
            char[] character = { 'A', 'B', 'C', 'D', 'E' };

            Generics getMethod = new Generics();
            getMethod.Print(integer);
            Console.WriteLine();
            getMethod.Print(doubles);
            Console.WriteLine();
            getMethod.Print(character);
        }
    }
}
