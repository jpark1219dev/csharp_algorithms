using System;
using System.Linq;

namespace reorganize_string
{
	class Program
	{
		static void Main(string[] args)
		{
			var input1 = "aab";
			var input2 = "aaab";

			var output1 = Solution.ReorganizeString(input1);
			var output2 = Solution.ReorganizeString(input2);

			Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
		}
	}

	class Solution
	{
		static internal string ReorganizeString(string S)
		{
			var letterCount = S.GroupBy(p => p)
				.Select(p => (val: p.Key, count: p.Count()))
				.OrderBy(p => p.count)
				.ToArray();

			if (letterCount[letterCount.Length - 1].count > (S.Length + 1) / 2) return string.Empty;
			//if more than half of the string is the same letter, it is impossible for an answer to exist


			var output = new char[S.Length];
			var index = 1;

			foreach (var (letter, count) in letterCount)
			//go through each valuetuple in letterCount array and fill them in output based on the letter and the number of its occurrence with odd index first and then even index to spread them out
			{
				for (var i = 0; i < count; i++)
				{
					if (index >= S.Length) index = 0;
					//reset the index to 0 after going over odd index write of new string to start with even index
					output[index] = letter;
					index += 2;
				}
			}

			return new string(output);
		}
	}
}
