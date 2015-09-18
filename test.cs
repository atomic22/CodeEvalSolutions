using System.IO;
using System;

Class FizzBizz{
	public static void main(String args[]){
		string line = "";
		using(StreamReader reader = File.OpenText(args[0]))
		while ((!reader.EndofStream))
		{
			line = reader.readLine();
		}
	}
}