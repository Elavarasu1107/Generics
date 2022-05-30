using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxFinder<T> where T : IComparable
    {
        private T[] parameters;

        public MaxFinder(params T[] parameters)
        {
            this.parameters = parameters;
        }
        public T ValueCheck()
        {
            Array.Sort(parameters);
            return parameters[parameters.Length-1];
        }
    }
}

