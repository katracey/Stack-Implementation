using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _151005_Challenge_StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
        }
    }
}*/
            StreamReader reader = new StreamReader("..\\..\\Input.txt");
            using (reader)
            {
                string[] lineArr;
                Stack<string> numStack = new Stack<string>();

                string line = reader.ReadLine();
                while (line != null)
                {
                    lineArr = line.Split(' ');

                    foreach (string num in lineArr)
                    {
                        numStack.Push(num);                        
                    }

                    for (int i = 0; i < lineArr.Length; i++)
                    {                        
                        if ((i % 2) == 0)
                        {
                            Console.Write(numStack.Pop() + " ");                                                   
                        }
                        else
                        {
                            numStack.Pop();
                        }
                    }
                    Console.WriteLine();
                    line = reader.ReadLine();
                }
            }
        }
    }
}
