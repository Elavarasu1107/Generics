using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxFinder<T> where T : IComparable
    {
        private T firstValue, secondValue, thirdValue;

        public MaxFinder(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public T ValueCheck()
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0
                || firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0
                || firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0
                || secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0
                || secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}

