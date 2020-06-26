using System;
using System.Collections.Generic;

namespace palindrome_number
{
    class Program
    {
        static void Main(string[] args)
        {
					var input1 = 121;
					var input2 = -121;
					var input3 = 10;

					var output1 = Solution.PalindromeNumber(input1);
					var output2 = Solution.PalindromeNumber(input2);
					var output3 = Solution.PalindromeNumber(input3);

          Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
        }

				class Solution
				{
					static internal bool PalindromeNumber(int num)
					{
						if (num < 0) return false;

						List<int> listOfInts = new List<int>();
						while (num > 0) 
						{
							listOfInts.Add(num % 10);
							num = num / 10;
						}

						bool isPalindrome = true;

						for (int i=0; i < listOfInts.Count/2; i++) {
							if (listOfInts[i] != listOfInts[listOfInts.Count - 1 - i]) {
								isPalindrome = false;
							}
						}

						return isPalindrome;
					}
				}
    }
}
