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

            int[] integer = { 1, 2, 3, 4, 5 };
            double[] doubles = { 1.1, 1.2, 1.3, 1.4, 1.5 };
            char[] character = { 'A', 'B', 'C', 'D', 'E' };

            Variable<int> intMethod = new Variable<int>(integer);
            intMethod.Print();
            Variable<double> doubleMethod = new Variable<double>(doubles);
            doubleMethod.Print();
            Variable<char> charMethod = new Variable<char>(character);
            charMethod.Print();
        }
    }
}
