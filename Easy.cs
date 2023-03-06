using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeTrening
{
    internal class Easy
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.You may assume that each input would have exactly one solution, and you may not use the same element twice.You can return the answer in any order. 
        ///<code> 
        ///Input: nums = [2,7,11,15], target = 9      
        /// Output: [0,1]        
        /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// </code>
        /// </summary>        
        public int[] TwoSum(int[] nums, int target)
        {
            int[] sum = new int[2];
            for (int i = 0; i < nums.Length; i++) {
                int index = Array.IndexOf(nums, target - nums[i]);
                if (index != -1) {
                    if (i < index)
                    {
                        sum[0] = i;
                        sum[1] = index;
                        break;
                    }
                    sum[0] = index;
                    sum[1] = i;
                }
            }         
            return sum;
        }

        /// <summary>
        /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input
        /// string is valid.An input string is valid if: Open brackets must be closed by the same type of brackets. Open
        /// brackets must be closed in the correct order. Every close bracket has a corresponding open bracket of the
        /// same type. <code>Example 1: Input: s = "()" Output: true   
        /// Example 2: Input: s = "(]" Output: false</code>
        /// </summary>

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++) 
            {
                char ch = s[i];
                switch (ch)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case ']':
                    case '}':
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != ch ) return false;
                        break;
                }                               
            } 
            return stack.Count == 0;
        }

        /// <summary>
        /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.Given a roman numeral, convert it to an integer.
        /// <code>
        /// Input: s = "MCMXCIV"
        /// Output: 1994
        /// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
        /// </code>
        /// </summary>
        public int RomanToInt(string s)
        {
            int finishNamber = 0;
            int indexNext = 0;
            string collecshon = "IVXLCDM";

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                    indexNext = collecshon.IndexOf(s[i + 1], 0);
                else indexNext = 0;
                int index = collecshon.IndexOf(s[i], 0);
                if (index < indexNext)
                {
                    finishNamber +=
                    (IndexInString(indexNext) - IndexInString(index));
                    i += 1;
                }
                else { finishNamber += IndexInString(index); }
            }
            return finishNamber;
        }

        private int IndexInString(int index)
        {
            int nam = 0;
            switch (index)
            {
                case 0: nam = 1; break;
                case 1: nam = 5; break;
                case 2: nam = 10; break;
                case 3: nam = 50; break;
                case 4: nam = 100; break;
                case 5: nam = 500; break;
                case 6: nam = 1000; break;
            }
            return nam;
        }
    }
}
