using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mth
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
                    if (line != null)
                    {

                        List<string> characters = line.Split(' ').ToList();
                        int index;
                        Int32.TryParse(characters[characters.Count - 1], out index);

                        characters.Reverse();
                        if (index < characters.Count)
                        {
                            Console.Out.WriteLine(characters[index]);
                        }
                        

                    }

                }
            }
            Console.Read();
        }
    }
}
