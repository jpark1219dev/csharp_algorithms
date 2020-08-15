using System;
using System.Text;

namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
					String[] input1 = new string[3]{"flower", "flow", "flight"};
					String[] input2 = new string[3]{"dog", "racecar", "car"};

					var output1 = Solution.LongestCommonPrefix(input1);
					var output2 = Solution.LongestCommonPrefix(input2);
          
					Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
        }
    }

		class Solution
		{
			static internal string LongestCommonPrefix(string[] strings) {
				if(strings.Length == 0) {
					return "";
				}
				string lastWord = strings[strings.Length-1];
				if(lastWord.Length == 0) {
					return "";
				}
				var commonPrefix = new StringBuilder();
				bool common = true;
				int charPosition = 0;

				while(common && lastWord.Length > charPosition) {
					char letterToCheck = lastWord[charPosition];
					for(int index=0; index<strings.Length-1; index++) {
						if(strings[index].Length < charPosition+1) {
							common = false;
						} else if (strings[index][charPosition]!=letterToCheck) {
							common = false;
						}
					}
					if(common) {
						commonPrefix.Append(lastWord[charPosition]);
						charPosition++;
					}
				}
				return commonPrefix.ToString();
			}
		}
}
