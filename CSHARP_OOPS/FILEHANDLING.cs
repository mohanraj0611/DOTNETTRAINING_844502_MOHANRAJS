using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //DirectoryInfo dir = new DirectoryInfo("c:\\sampledirectory");
            //dir.Create();
            //FileInfo file = new FileInfo("c:\\sampledirectory\\sample.txt");
            //file.Create();s
            //Console.WriteLine("directory and file created");

            FileStream fs = new FileStream("c:\\sampledirectory\\sample.txt",FileMode.Append,FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("APENDED CONTENT");
            


            Console.WriteLine("mohan");

            StringBuilder s = new StringBuilder("mohan", 10);

            s.Append("raj");

            s.AppendLine("vimal");

            Console.WriteLine(s.ToString());


            sw.Close();
            fs.Close();


            fs = new FileStream("c:\\sampledirectory\\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

           


            //var firstLine = sr.ReadLine(); reading only first line

            //var content = sr.ReadToEnd();reading upto endof line

            //line by line

            //string linebyline;

           // while((linebyline=sr.ReadLine())!= null)
            //{
               // Console.WriteLine("the file content is {0}", linebyline);
            //}

            //Console.WriteLine("the content in the file is {0}",linebyline);                                     

            sr.Close();
            fs.Close();

            Console.WriteLine("content written in file sucessfully");



               






            Console.ReadKey();
        }
    }
}
