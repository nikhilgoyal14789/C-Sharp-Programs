using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            Parent obj1 = obj;          //This is known as Upcasting (Automatically happens)
            obj.Read();

            Child obj2 = (Child)obj1;   //This is known as Downcasting (Explicit TypeCasting Required)
            obj2.Read();
            obj2.Calc();

            //Boxing and Unboxing
            int number = 20;
            Object box = number;        //Boxing (Coverting primitive type to object type)
            Console.WriteLine(box);

            int number1 = (int)box;     //Unboxing (Converting object type to primitive type) - Explicit Typecasting is required
            Console.WriteLine(number1);
            Console.ReadKey();
        }
    }
}
