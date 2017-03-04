using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\..\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (!char.IsWhiteSpace(ch))
                        {
                            if(char.IsPunctuation(ch))
                            {
                                if(ch=='.')
                                    Console.Write(ch+"\n");
                                else if(ch=='?')
                                    Console.Write(ch + "\n");
                                else if(ch=='!')
                                    Console.Write(ch + "\n");
                                else
                                    Console.Write(ch);
                            }   
                            else
                                Console.Write(ch);
                        }
                        else
                            Console.Write(ch);
                    }
                }
            }
        }
    }
}
