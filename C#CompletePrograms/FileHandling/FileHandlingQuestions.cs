using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileHandling
{
    class FileHandlingQuestions
    {
        static void Main(string[] args)
        {
            //1- Write a program that reads a text file and displays the number of words.
            string path = @"C:\Users\Unthinkable-lap-0292\Desktop\NFolder1\PractiseFile.txt";
            string fileText = File.ReadAllText(path);
            var len = fileText.Split(' ');

            Console.WriteLine("File Words Length is " + len.Length);
      

            //2 - Write a program that reads a text file and displays the longest word in the file.

            var longestWordLength = 0;
            var longestWordText = " ";
            foreach(var res in len)
            {
                if (res.Length > longestWordLength)
                {
                    longestWordLength = res.Length;
                    longestWordText = res;
                }
            }

            Console.WriteLine("Longest Word Text is {0} and Longest Word Length is {1}",longestWordText,longestWordLength);
            Console.ReadKey();
            }
    }
}
