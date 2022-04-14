using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //public class Student
    //{
    //    public string name;
    //    public int sec;
        
    //    public Student()
    //    {

    //    }
    //    public Student(string name, int sec)
    //    {
    //        this.name = name;
    //        this.sec = sec;
    //    }

    //    public void studentInformation()
    //    {
    //        Console.WriteLine("Student name is {0} & Student section is {1} ", name, sec);
    //    }

    //    public static void Parse()
    //    {
    //        Console.WriteLine("Hello");
    //        //Student obj = new Student();
    //        //obj.name = "Nikhil";
    //        //obj.sec = 12;
    //        //return obj;
    //    }
    //}
    public class Program
    {
        //int num2;
        //Console.WriteLine(num);
        static void Main(string[] args)
        {
            int num2;
            //Program o = new Program();
            Console.WriteLine(num2);
            Console.WriteLine("====================================OOPS================================================");

            //var obj = new Student("a",1);
            ////obj.studentInformation();
            ////var res=Student.Parse();
            ////res.studentInformation();
            //Add(2.4f, 2);
            //Add(new int[] { 1, 2, 3, 4 });

            //var a=2;
            //Ref(out a);
            //Console.WriteLine(a);

            int number;
            var result = int.TryParse("a1", out number);
            Console.WriteLine(number);
            Console.WriteLine(result);
            new Program().a();

            int num;
            Console.WriteLine(num);

            if(string.IsNullOrWhiteSpace(num))
                Console.WriteLine("Yes");
            Console.ReadKey();
        }
        void a()
        {
            Console.WriteLine("e");
        }
        //static void Ref(out int a)
        //{
        //    a + = 20;
        //}
        //static void Add(params int[] a)
        //{
        //    var total = 0;
        //    foreach(int i in a)
        //    {
        //        total += i;
        //    }
        //    Console.WriteLine(total);
        //}
        //static void Add(int a, float b)
        //{
        //    Console.WriteLine("Int->Float");
        //}
        //static void Add(float a, int b)
        //{
        //    Console.WriteLine("Float->Int");
        //}
    }

}
