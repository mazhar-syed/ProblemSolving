using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//https://leetcode.com/problems/two-sum/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class TwoSum1
    {
        public static void Execute()
        {
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 2, 7, 11, 15 }, 9))); //0,1
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 3, 2, 4 }, 6)));    //1,2
            Console.WriteLine(string.Join(",", TwoSum(new int[] { 3, 3 }, 6)));  //0,1

            Console.WriteLine(string.Join(",", TwoSum(new int[] { -3, 8, -5, 7, 100, 14, 17 }, 9))); //2,5

            Console.WriteLine(string.Join(",", TwoSum(new int[] { -3, 8, -5, -20, -20, 7, 100, 14, 17 }, 9))); //2,5
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var valueIndexMap = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (valueIndexMap.ContainsKey(diff))
                {
                    return new int[] { i, valueIndexMap[diff] };
                }
                if (!valueIndexMap.ContainsKey(nums[i])) valueIndexMap.Add(nums[i], i);
            }
            return new int[] { };
        }

        public static int[] TwoSumAttempt1(int[] nums, int target)
        {
            var valueIndexMap = new Dictionary<int, List<int>>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (valueIndexMap.ContainsKey(nums[i]))
                    valueIndexMap[nums[i]].Add(i);
                else
                    valueIndexMap.Add(nums[i], new List<int>() { i });
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - (nums[i]);
                if (valueIndexMap.ContainsKey(diff))
                {
                    foreach(var index in valueIndexMap[diff])
                        if(index != i)
                            return new int[] { i, index };
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
