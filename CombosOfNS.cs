using System;

namespace Application
{
	public class CombosOfNS
	{
		public static void Main ()
		{
			//1,aa = a
			//2,ab = aa,ab,ba,bb
			//3,pop = ooo,oop,opo,poo,pop,ppo,ppp
			//write a string of length N from the characters in string S, comma delimited in alphabetical order

			string input = "2,ab";

			string[] ns = input.Split (new char []{ ',' });

			int n = Int32.Parse (ns [0]);

			char[] s = ns [1].ToCharArray ();

			string output = "";

			for (int i = 0; i < n; i++) {
				output += s [i];
			}

			Console.WriteLine (output);
		}


	}
}