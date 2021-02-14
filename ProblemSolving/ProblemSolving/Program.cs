using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCode.LeetCodeMain.Run();
            HackerRank.HackerRankMain.Run();
            CodeForces.CodeForcesMain.Run();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
