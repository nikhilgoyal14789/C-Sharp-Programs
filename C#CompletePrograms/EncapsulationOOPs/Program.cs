using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOOPs
{
    class Encapsulation
    {
        //private string _name;

        /*First Approach
        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }*/

        //Second Approach using Property Class
        public string Name
        {
            get { return "Your Name is : "+this._name; }
            set { this._name = value; }
        }

        /*Third Approach using Auto Implemented methods of Getter and Setter in this approach there is no need to define private
        variable compiler will define the private variable for corresponding property name and compiler defines the getter and setter
        Method according to property name.
        public string Name { get; set; }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();
            //obj.Name("Nikhil");
            //Console.WriteLine(obj.Name());
            obj.Name = "Nikhil";
            Console.WriteLine(obj.Name);
            Console.ReadKey();
        }
    }
}
