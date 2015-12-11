using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("Test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    StringBuilder sb = new StringBuilder();
                    int count = 0;
                    
                   for (int i = 0; i < line.Length; i ++)
                    {
                        if (Char.IsLetter(line[i]))
                        {
                            if (count % 2 == 0)
                            {
                                sb.Append(line[i].ToString().ToUpper());
                            }
                            else
                            {
                                sb.Append(line[i].ToString().ToLower());
                            }
                            count++;
                        }
                        else
                        {
                            sb.Append(line[i].ToString());
                        }
                       
                    }
                    Console.Out.WriteLine(sb.ToString());
                }
                Console.Read();
            }
        }

    }
}
