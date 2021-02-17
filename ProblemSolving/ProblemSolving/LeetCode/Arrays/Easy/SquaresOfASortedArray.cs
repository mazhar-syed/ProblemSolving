using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//https://leetcode.com/problems/squares-of-a-sorted-array/
namespace ProblemSolving.LeetCode.Arrays.Easy
{
    public class SquaresOfASortedArray
    {
        public static void Execute()
        {
            Console.WriteLine(string.Join(',', SortedSquares(new int[] { -4, -1, 0, 3, 10 }))); //[0,1,9,16,100]
            Console.WriteLine(string.Join(',', SortedSquares(new int[] { -7, -3, 2, 3, 11 }))); //[4,9,9,49,121]
            Console.WriteLine(string.Join(',', SortedSquares(new int[] { -1 }))); //[1]
            Console.WriteLine(string.Join(',', SortedSquares(new int[] { -7, -3 }))); //[9,49]
        }

        public static int[] SortedSquares(int[] nums)
        {
            var squares = new List<int>();
            var pos = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) pos++;
                else break;
            }

            int pi = pos + 1; int ni = pos;
            while (true)
            {
                if ( (ni < 0 && pi < nums.Length) || (pi < nums.Length && nums[pi] < (-(nums[ni])))  )
                {
                    squares.Add(nums[pi] * nums[pi]);
                    pi++;
                    continue;
                }
                if(ni >= 0)
                {
                    squares.Add((nums[ni]) * (nums[ni]));
                    ni--;
                }

                if (pi >= nums.Length && ni < 0) break;
            }

            squares.Sort();
            return squares.ToArray();
        }

        public static int[] SortedSquares2(int[] nums)
        {
            var squares = new List<int>();
            var pos = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0) pos++;
                else break;
            }

            int pi = pos+1; int ni = pos;
            while (pi < nums.Length && ni >= 0)
            {
                if(nums[pi] < (-(nums[ni])))
                {
                    squares.Add( nums[pi] * nums[pi] );
                    pi++;
                }
                else
                {
                    squares.Add((nums[ni]) * (nums[ni]));
                    ni--;
                }
            }

            for(int i = ni; i >= 0; i--)
                squares.Add((nums[i]) * (nums[i]));

            for (int i = pi; i < nums.Length; i++)
                squares.Add((nums[i]) * (nums[i]));
            
            squares.Sort();
            return squares.ToArray();
        }

        public static int[] SortedSquares1(int[] nums)
        {
            var squares = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
                squares[i] = (nums[i]) * (nums[i]);
            var list = squares.ToList();
            list.Sort();
            return list.ToArray();
        }
    }
}
