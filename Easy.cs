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
    }
}
