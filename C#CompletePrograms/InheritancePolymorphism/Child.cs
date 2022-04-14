using System;

namespace InheritancePolymorphism
{
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Class Constructor ");
        }

        public sealed override void Calc()
        {
            Console.WriteLine("Child Class Abstract Method Implementation");
        }

        public override void Read()
        {
            Console.WriteLine("Child Class Method");
        }
    }

    class Sibling : Child
    {
        public override void Calc()
        {
            
        }
    }
}
