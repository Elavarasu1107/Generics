using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Variable<T>
    {
        private T[] inputArray;
        public Variable(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void Print()
        {
            foreach (var data in inputArray)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
