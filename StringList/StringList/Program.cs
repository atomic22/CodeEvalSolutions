using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();
            
            int stringLength = 0;
            using (StreamReader reader = File.OpenText("Test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] lineInfo = line.Split(',');
                    
                    Int32.TryParse(lineInfo[0].ToString(), out stringLength);

                    //add the leter combos to the letters list
                    letters.Add(lineInfo[1].ToString());
                    
                }

                Combos(stringLength, letters);
            }
            Console.Read();
        }

        static void Combos(int sLength, List<string> letters)
        {
            foreach (var letter in letters)
            {
                foreach (var let in letter)
                {
                    Console.WriteLine(let);
                }
            }
        }
    }
}
