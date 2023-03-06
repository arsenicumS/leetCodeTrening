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
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add
        /// up to target.You may assume that each input would have exactly one solution, and you may not use the same
        /// element twice.You can return the answer in any order.  /// <code>Input: nums = [2,7,11,15], target = 9     
        /// Output: [0,1]         Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].</code>
        /// </summary>        
        public int[] TwoSum(int[] nums, int target)
        {
            int[] sum = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                int index = Array.IndexOf(nums, target - nums[i]);
                if(index != -1)
                {
                    if(i < index)
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
        /// same type. <code>Example 1: Input: s = "()" Output: true  Example 2: Input: s = "()[]{}" Output: true 
        /// Example 3: Input: s = "(]" Output: false</code>
        /// </summary>

        public bool IsValid(string s)
        {
            int rezult = 0;
            foreach(char ch in s)
            {
                switch(ch)
                {
                    case '(':
                        var valid = s.IndexOf(')');
                        if(valid == -1 || s.IndexOf('(') > valid)
                        {
                            return false;
                        }
                        rezult += 2;
                        break;
                    case '{':
                        var valid_2 = s.IndexOf('}');
                        if(valid_2 == -1 || s.IndexOf('{') > valid_2)
                        {
                            return false;
                        }
                        rezult += 2;
                        break;
                    case '[':
                        var valid_3 = s.IndexOf(']');
                        if(valid_3 == -1 || s.IndexOf('[') > valid_3)
                        {
                            return false;
                        }
                        rezult += 2;
                        break;
                }
            }
            return rezult % 2 == 0;
        }
    }
}
