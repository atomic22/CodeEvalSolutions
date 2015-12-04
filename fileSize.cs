using System;
using System.IO;

namespace Application
{
	public class fileSize
	{
		public static void Main (String[] arg)
		{
			FileInfo f = new FileInfo(arg[0]);
			long fs = f.Length; 
			Console.WriteLine (fs);	

			Console.Read ();
		}
	}
}