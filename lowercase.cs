using System;
using System.IO;
using System.Text;

namespace Application
{
	public class lowercase
	{
		public static void Main (string[] args)
		{
			using (StreamReader sr = new StreamReader (args [0])) {
				string line;
				while ((line = sr.ReadLine ()) != null)
					Console.WriteLine (line.ToLower ());
			}

		}
	}
}

