using System;

namespace Problems.Chapter8 
{
    // Triple Step
    public class Problem1 
    {
        public static int CountWays(int steps) 
        {
            if (steps < 0)
                return 0;
            if (steps == 0)
                return 1;
            // Possibilities from 
            return CountWays(steps - 1) +
                   CountWays(steps - 2) + 
                   CountWays(steps - 3);
        }
    }
}