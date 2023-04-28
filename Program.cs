using System;
using System.Collections.Generic;
using System.Linq;

namespace divisibleSumPairs
{
	class Program
	{
		//https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true
		public static int divisibleSumPairs(int n, int k, List<int> ar)
		{
			int pairs = 0;
			ar.Sort();

			for (int i = 0; i < ar.Count; i++)
			{
				for (int j = i+1; j < ar.Count; j++)
				{
					if( (ar[i]+ar[j]) % k == 0)
					{
						pairs++;
					}
				}
			}
			return pairs;
		}

		static void Main(string[] args)
		{
			string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

			int n = Convert.ToInt32(firstMultipleInput[0]);

			int k = Convert.ToInt32(firstMultipleInput[1]);

			List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

			int result = divisibleSumPairs(n, k, ar);

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
