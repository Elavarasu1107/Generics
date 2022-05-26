using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics
    {
        public void Print(int[] details)
        {
            foreach(var data in details)
            {
                Console.Write(data+" ");
            }
        }
        public void Print(double[] details)
        {
            foreach (var data in details)
            {
                Console.Write(data + " ");
            }
        }
        public void Print(char[] details)
        {
            foreach (var data in details)
            {
                Console.Write(data + " ");
            }
        }
    }
}
