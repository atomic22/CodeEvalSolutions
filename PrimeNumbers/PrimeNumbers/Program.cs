using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int celing;
                    Int32.TryParse(reader.ReadLine(), out celing);
                        for (int i = 3; i <= 100; i+=2)
                        {
                            if (celing % i == 0)
                            {

                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                    
                    
                }
            }
            Console.Read();
        }
    }
}
