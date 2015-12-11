using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("Text")) 
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                }
            }
        }
    }
}
