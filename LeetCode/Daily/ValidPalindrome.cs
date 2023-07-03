using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №125
    public class ValidPalindrome
    {
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                var left = 0;
                var right = s.Length - 1;

                while (right > left)
                {
                    if (!char.IsLetterOrDigit(s[left]))
                    {
                        left++;
                    }
                    else if (!char.IsLetterOrDigit(s[right]))
                    {
                        right--;
                    }
                    else if (char.ToLowerInvariant(s[right]) != char.ToLowerInvariant(s[left]))
                    {
                        return false;
                    }
                    else if (char.ToLowerInvariant(s[right]) == char.ToLowerInvariant(s[left]))
                    {
                        left++;
                        right--;
                    }
                }

                return true;
            }
        }
    }
}
