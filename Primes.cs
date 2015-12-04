using System;
using System.Text;
using System.Collections.Generic;


//checking for prime numbers
namespace Application
{
	public class Primes
	{
		
		public static void Main (string[] args)
		{
			int number = 2;
			int sum = 0;
			int count = 0;

			while (count < 1000) {
				if (isPrime (number)) {
					sum += number;
					count++;	
				}
				number++;
			}


			Console.Out.WriteLine (sum);

		}


		public static bool isPrime (int number)
		{
			for (int i = 2; i < number; i++) {
				if (number % i == 0) {
					return false;
				}

			}
			return true;
		}
	}
}