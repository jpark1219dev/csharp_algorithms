using System;
using System.Collections.Generic;
using System.Linq;

namespace valid_parentheses
{
    class Program
    {
      static void Main(string[] args)
      {
        var input1 = "()";
        var input2 = "()[]{}";
        var input3 = "(]";
        var input4 = "([)]";
        var input5 = "{[]}";

				var output1 = Solution.ValidParentheses(input1);
				var output2 = Solution.ValidParentheses(input2);
				var output3 = Solution.ValidParentheses(input3);
				var output4 = Solution.ValidParentheses(input4);
				var output5 = Solution.ValidParentheses(input5);

				Console.WriteLine("Done! Insert breakpoint here and inspect the outputs!");
      }
    }

		class Solution
		{
			static internal bool ValidParentheses(string s) {
				var characters = s.ToCharArray().ToList();
				var isValidTracker = new List<char>();
				isValidTracker.Add('a');
				foreach (var character in characters) {
					if(character == '[' || character == '{' || character == '('){
						isValidTracker.Add(character);
					} else if (character == ']' && isValidTracker[isValidTracker.Count-1] == '[') {
						isValidTracker.RemoveAt(isValidTracker.Count-1);
					} else if (character == '}' && isValidTracker[isValidTracker.Count-1] == '{') {
						isValidTracker.RemoveAt(isValidTracker.Count-1);
					} else if (character == ')' && isValidTracker[isValidTracker.Count-1] == '(') {
						isValidTracker.RemoveAt(isValidTracker.Count-1);
					} else {
						isValidTracker.Add(character);
					}
				}
				return isValidTracker.Count == 1 && isValidTracker[0] == 'a';
			}
		}
}
