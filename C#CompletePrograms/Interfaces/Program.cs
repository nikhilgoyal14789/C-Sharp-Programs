using System;

namespace Interfaces
{
    interface IPractise
    {
        void Result();
    }
    interface IPractise1
    {
        void Result1();
    }

    class Imp : IPractise , IPractise1          //Interface supports Multiple Inheritance Concept and it provide Securitys
    {
        public void Result()
        {
            Console.WriteLine("Interface Implementation");
        }

        public void Result1()
        {
            Console.WriteLine("Interface Implementation 1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Imp obj = new Imp();
            obj.Result();
            obj.Result1();
            object a="ab";
            Console.WriteLine(a);
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
