using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DP
{
    public class MinStepsToMinimize
    {
        static Dictionary<int, int> solved = new Dictionary<int, int>();    
        public static void Execute()
        {
            Console.WriteLine(MinimizeBottomUp(5)); //3
            Console.WriteLine(MinimizeBottomUp(7)); //3
            Console.WriteLine(MinimizeBottomUp(10)); //3
            Console.WriteLine(MinimizeBottomUp(99)); //6
        }

        //Recursive
        static int MinimizeTopDown(int n)
        {
            if (n == 1) return 0;

            if (solved.ContainsKey(n)) return solved[n];    //memoization

            int minSteps = 1 + MinimizeTopDown(n - 1);
            if (n % 2 == 0)
                minSteps = Math.Min(minSteps, 1 + MinimizeTopDown(n / 2));
            
            if (n % 3 == 0)
                minSteps = Math.Min(minSteps, 1 + MinimizeTopDown(n / 3));

            //store the result for n 
            solved[n] = minSteps;

            return minSteps;
        }

        //Tabulation
        static int MinimizeBottomUp(int n)
        {
            Dictionary<int, int> tab = new Dictionary<int, int>();
            tab[1] = 0; tab[2] = 1; tab[3] = 1;         //base conditions

            for(int i = 4; i <= n; i++)
            {
                int minSteps = 1 + tab[i - 1];
                if (i % 2 == 0)
                    minSteps = Math.Min(minSteps, 1 + tab[i / 2]);

                if (i % 3 == 0)
                    minSteps = Math.Min(minSteps, 1 + tab[i / 3]);

                tab.Add(i, minSteps);
            }

            return tab[n];
        }
    }
}
