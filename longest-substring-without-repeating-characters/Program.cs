using System;
using System.Collections.Generic;
using System.Text;

namespace longest_substring_without_repeating_characters
{
	class Program
	{
		static void Main(string[] args)
		{
			var input1 = "abcabcbb";
			var input2 = "bbbbb";
			var input3 = "pwwkew";

			var output1 = Solution.LongestSubstringWithoutRepeatingCharacters(input1);
			var output2 = Solution.LongestSubstringWithoutRepeatingCharacters(input2);
			var output3 = Solution.LongestSubstringWithoutRepeatingCharacters(input3);

			Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
		}
	}
	class Solution
	{
		static internal int LongestSubstringWithoutRepeatingCharacters(string S) 
		{
			var stringBuilder = new StringBuilder();
			var longestLength = 0;
			foreach (char x in S.ToCharArray()) {
				stringBuilder.Append(x);
				if(isUnique(stringBuilder.ToString()))
				{
					if (longestLength < stringBuilder.Length) {
						longestLength = stringBuilder.Length;
					}
				} else {
					stringBuilder = stringBuilder.Remove(0, stringBuilder.ToString().IndexOf(x) + 1);
				}
			}
			return longestLength;
		}

		static private bool isUnique(string S)
		{
			var lettersArray = S.ToCharArray();
			var lettersSeen = new List<char>();
			var unique = true;
			foreach (char x in lettersArray) {
				if(!lettersSeen.Contains(x)) {
					lettersSeen.Add(x);
				} else {
					unique = false;
				}
			}
			return unique;
		}
	}
}
