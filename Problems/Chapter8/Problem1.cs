using System;

namespace Problems.Chapter8 
{
    // Triple Step
    public class Problem1 
    {
        public static int CountStepsByOneTwoThree(int steps) 
        {
            if (steps < 0)
                return 0;
            if (steps == 0)
                return 1;
            // Possibilities from 
            return CountStepsByOneTwoThree(steps - 1) +
                   CountStepsByOneTwoThree(steps - 2) + 
                   CountStepsByOneTwoThree(steps - 3);
        }
    }
}