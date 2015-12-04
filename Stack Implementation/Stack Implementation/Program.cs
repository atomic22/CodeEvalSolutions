using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<int> nums = new List<int>();
                    string[] numbers = line.Split(' ');
                    int num;
                    
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Int32.TryParse(numbers[i], out num);
                        nums.Add(num);
                    }
                    
                    nums.Reverse();

                    for (int i = 0; i < nums.Count; i=i+2)
                    {

                        Console.Out.Write(nums[i]);

                        if (i<nums.Count)
                        {
                            Console.Out.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
                Console.Read();
            }
        }
    }
}
