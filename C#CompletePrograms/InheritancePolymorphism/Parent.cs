using System;

namespace InheritancePolymorphism
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Class Constructor ");
        }

        public virtual void Calc()
        {

        }
        public virtual void Read()
        {
            Console.WriteLine("Parent Class Method");
        }
     
    }
}
