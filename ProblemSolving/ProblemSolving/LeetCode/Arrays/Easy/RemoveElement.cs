using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/remove-element/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class RemoveElement
    {
        public static void Execute()
        {
            var nums = new int[] { 3, 2, 2, 3 };
            int len = RemoveElementFromArray(nums, 3);   //2, nums = [2,2]
            Console.WriteLine($"Len: {len} => [" + string.Join(',', nums) + "]");

            nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            len = RemoveElementFromArray(nums, 2); //5, nums = [0,1,4,0,3]
            Console.WriteLine($"Len: {len} => [" + string.Join(',', nums) + "]");
        }

        public static int RemoveElementFromArray(int[] nums, int val)
        {
            var current = 0;
            for(int i = 0; i < nums.Length; i++)
                if(nums[i] != val) nums[current++] = nums[i];

            return current;
        }
    }
}
