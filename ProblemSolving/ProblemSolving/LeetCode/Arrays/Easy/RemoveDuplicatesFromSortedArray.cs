using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static void Execute()
        {
            var nums = new int[] { 1, 1, 2 };
            int len = RemoveDuplicates(nums);
            Console.WriteLine($"Len: {len} => [" + string.Join(',', nums) + "]"); //2 => 1,2

            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            len = RemoveDuplicates(nums);
            Console.WriteLine($"Len: {len} => [" + string.Join(',', nums) + "]");   //5 => 0,1,2,3,4
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            var currIndex = 0;
            for( int i = 1; i < nums.Length; i++ )
            {
                if(nums[i] != nums[currIndex])
                {
                    currIndex += 1;
                    nums[currIndex] = nums[i];
                }
            }

            return currIndex + 1;
        }
    }
}
