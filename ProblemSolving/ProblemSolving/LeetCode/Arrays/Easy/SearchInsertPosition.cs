using System;
using System.Collections.Generic;
using System.Text;
//https://leetcode.com/problems/search-insert-position/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class SearchInsertPosition
    {
        public static void Execute()
        {
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 5));  //2
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));  //1
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 7));  //4
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 0));  //0
            Console.WriteLine(SearchInsert(new int[] { 1 }, 0));  //0
            Console.WriteLine(SearchInsert(new int[] { 1, 5, 8, 10, 13, 17}, 9));  //3
            Console.WriteLine(SearchInsert(new int[] { 1 }, 1));  //0
            Console.WriteLine(SearchInsert(new int[] { 1 }, 2));  //1
            Console.WriteLine(SearchInsert(new int[] { 1, 3 }, 3));  //1
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            do
            {
                int mid = (low + high) / 2;
                if (target == nums[mid]) return mid;
                else if (target < nums[mid]) high = (mid - 1) >= 0 ? mid - 1 : low;
                else if (target > nums[mid]) low = (mid + 1) < nums.Length ? mid + 1 : high;
            } while (low < high);

            if (nums[low] == target) return low;

            return nums[low] > target ? low : low + 1;
        }
    }
}
