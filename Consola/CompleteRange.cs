using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola
{
    internal class CompleteRange
    {
        public int[] build(int[] arrayNumber)
        {
            var max = arrayNumber.Max();

            int[] newArray = new int[max];

            for (int i = 0; i < max; i++)
            {
                newArray[i] = i + 1;

            }

            return newArray;

        }  
    }
}

