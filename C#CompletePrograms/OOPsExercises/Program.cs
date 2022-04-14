using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            str1 = "C#";
            str2 = "C#";
            int[] arr = { 1, 2 };

            Console.WriteLine($"{str1} {str2}");
            Console.WriteLine(str1.Equals(str2));

            //int a = 10;
            int[] arra =  { 1, 2, 3, 4, 5 };
            try
            {
                //return arra[10];
                Console.WriteLine(arra[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                return 0;
            }
            //Console.WriteLine(arra);
            Console.ReadKey();
        }
     
    }
}
