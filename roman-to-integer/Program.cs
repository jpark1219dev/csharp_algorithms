using System;
using System.Collections.Generic;

namespace roman_to_integer
{
    class Program
    {
      static void Main(string[] args)
      {
        var input1 = "III";
				var input2 = "IV";
				var input3 = "IX";
				var input4 = "LVIII";
				var input5 = "MCMXCIV";

				var output1 = Solution.RomanToInteger(input1);
				var output2 = Solution.RomanToInteger(input2);
				var output3 = Solution.RomanToInteger(input3);
				var output4 = Solution.RomanToInteger(input4);
				var output5 = Solution.RomanToInteger(input5);

				Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
      }
    }

		class Solution
		{
			static internal int RomanToInteger(string s) {
				var sum = 0;
				Dictionary<char, int> dictTranslator = new Dictionary<char, int>();
				void initDictList() {
					dictTranslator.Add('I', 1);
					dictTranslator.Add('V', 5);
					dictTranslator.Add('X', 10);
					dictTranslator.Add('L', 50);
					dictTranslator.Add('C', 100);
					dictTranslator.Add('D', 500);
					dictTranslator.Add('M', 1000);
				}
				initDictList();
				for (int index = 0; index < s.Length-1; index++)
				{
					if (s[index] == 'I' && s[index+1] == 'V' || s[index] == 'I' && s[index+1] == 'X')
					{
						sum -= dictTranslator[s[index]];
					} else if (s[index] == 'X' && s[index+1] == 'L' || s[index] == 'X' && s[index+1] == 'C')
					{
						sum -= dictTranslator[s[index]];
					} else if (s[index] == 'C' && s[index+1] == 'D' || s[index] == 'C' && s[index+1] == 'M')
					{
						sum -= dictTranslator[s[index]];
					} else {
						sum += dictTranslator[s[index]];
					}
				}
				sum += dictTranslator[s[s.Length-1]];
				return sum;
			}
		}
}
