using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //const int alphabetCount = 26;
            //var array = new char[alphabetCount];
            //for(var i=0;i<alphabetCount;i++)
            //{
            //    array[i]=(char)('a'+random.Next(0,alphabetCount));
            //}
            //var result = new string(array);
            //Console.WriteLine(result);

            //var a = new int[3,5];
            //a[0,0] = 1;
            //Console.WriteLine(a.Length);


//           1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

          /*  Console.WriteLine("Enter UserName :- ");
            var list = new List<String>();
            string s = "";
            do
            {
                s = Console.ReadLine();
                list.Add(s);
            } while (s != "");

            int length =list.Count;
            length--;
            if(length==1)
                Console.WriteLine("[{0}] liked your post ",list[0]);
            else if (length == 2)
                Console.WriteLine("[{0}] , [{1}] liked your post ", list[0], list[1]);
            else
                Console.WriteLine("[{0}] , [{1}] , [{2}] others liked your post ", list[0],list[1],(length-2));*/


            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            Console.WriteLine("Enter 5 Unique Numbers :- ");
            int n = 0;
            var list = new List<int>();
            int c = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(n))
                {
                    Console.WriteLine("No is already exist try again");
                    continue;
                }
                else
                    list.Add(n);
                c++;
            } while (c!=5);

            list.Sort();
            Console.WriteLine("Your Entered Numbers are :- ");
            foreach(var i in list)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
