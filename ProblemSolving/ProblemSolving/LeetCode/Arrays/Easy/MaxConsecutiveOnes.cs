using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/max-consecutive-ones/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class MaxConsecutiveOnes
    {
        public static void Execute()
        {
            Console.WriteLine(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 })); //3
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0, currMax = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    currMax += 1;
                }
                else
                {
                    if (currMax > max)
                        max = currMax;
                    currMax = 0;
                }
            }
            return currMax > max ? currMax : max;
        }
    }
}
