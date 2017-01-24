using System;

namespace exactSumRealNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			decimal finalSum = 0;

			for (int i = 0; i < n; i++)
			{
				decimal sumNumber = decimal.Parse(Console.ReadLine());
				finalSum += sumNumber;
			}

			Console.WriteLine(finalSum);
		}
	}
}
