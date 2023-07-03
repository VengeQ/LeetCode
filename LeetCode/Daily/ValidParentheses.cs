using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        public class Solution
        {
            public Solution()
            {
                _mapper['}'] = '{';
                _mapper[']'] = '[';
                _mapper[')'] = '(';
            }

            private readonly IDictionary<char, char> _mapper = new Dictionary<char, char>();

            public bool IsValid(string s)
            {
                if (s.Length % 2 != 0)
                {
                    return false;
                }

                var stack = new Stack<char>();
                
                foreach (char c in s)
                {
                    if (IsOpen(c))
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (!stack.TryPop(out var value) || _mapper[value] != c)
                        {
                            return false;
                        }
                    }
                }

                return !stack.Any();
            }

            private bool IsOpen(char symbol) => symbol == '{' || symbol == '[' || symbol == '(';

        }
    }
}
