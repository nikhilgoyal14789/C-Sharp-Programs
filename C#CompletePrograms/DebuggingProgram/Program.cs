using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 0, 40};
            int result = findMax(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int findMax(int[] array)
        {
            int maxElement = int.MinValue;
            foreach(int i in array)
            {
                if (i > maxElement)
                    maxElement = i;
            }
            return maxElement;
        }
    }
}
