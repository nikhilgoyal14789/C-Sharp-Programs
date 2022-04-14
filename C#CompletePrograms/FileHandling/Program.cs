using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main1(string[] args)
        {
            string cpath = @"D:\Generic Training Materials\pic.jpg";
            string dpath = @"C:\Users\Unthinkable-lap-0292\Desktop\pic.jpg";
            File.Delete(dpath);
            //Console.WriteLine(result);

            //File.Copy(cpath, dpath, true);
            if (File.Exists(cpath))
                Console.WriteLine("Hurray File Found");

            //Console.WriteLine(File.ReadAllText(dpath));

            //File Info (Instance Methods)
            var fileInfo=new FileInfo(cpath);

            //fileInfo.CopyTo(dpath);
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //exists is a property not methods
            }

            //Directory (Static Methods)

            string dirpath = @"C:\Users\Unthinkable-lap-0292\Desktop\NFolder1";
            //Directory.CreateDirectory(dirpath);
            var result=Directory.Exists(dirpath);
            if(result)
            {
                Console.WriteLine("Folder Found");
            }
            else
            {
                Console.WriteLine("Folder Not Found");
            }

            var files=Directory.GetFiles(dirpath, "*.*", SearchOption.AllDirectories);

            foreach(var file in files)
                Console.WriteLine(file);

            //DirectoryInfo (Contains Instance Methods)
            var directoryInfo = new DirectoryInfo(dirpath);

            var a =directoryInfo.GetFiles();
            foreach(var b in a)
                Console.WriteLine("Directory Files is :- "+b);
            var c=directoryInfo.GetDirectories();
            foreach(var e in c)
                Console.WriteLine("Directory Folder is "+e);


            //Path Class (Using Static Methods)
            Console.WriteLine("Extension is "+Path.GetExtension(cpath));
            Console.WriteLine("File name is "+Path.GetFileName(cpath));
            Console.WriteLine("File name without extension is "+Path.GetFileNameWithoutExtension(cpath));
            Console.WriteLine("Directory Name is "+Path.GetDirectoryName(cpath));

            Console.ReadKey();
        }
    }
}
