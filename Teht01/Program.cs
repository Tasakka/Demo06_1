using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "/n";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"E:\koulu\Olio-ohjelmointi\test.txt");
            while (data != "")
            {
                Console.WriteLine("Give a text line: ");
                data = Console.ReadLine();
                if (data != "")
                {
                    outputFile.WriteLine(data);
                }
            }
            outputFile.Close();
            string text = System.IO.File.ReadAllText(@"E:\koulu\Olio-ohjelmointi\test.txt");
            System.Console.WriteLine(text);
        }
    }
}
