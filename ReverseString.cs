using System;
using System.IO;
using System.Collections.Generic;

namespace Application
{
	public class ReverseString
	{
		

		public static void Main (string[] args)
		{
			//List<string> lines = new List<string> ();
			//string inputLines;
			using (StreamReader sr = File.OpenText (args [0]))
				while (sr.Peek () >= 0) {
					//string[] words;

					string[] words = sr.ReadLine ().Split (null);
					Array.Reverse (words);
					Console.WriteLine (string.Join (" ", words));

				}
		}
	}
}