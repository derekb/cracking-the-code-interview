using System;
using System.Collections.Generic;

namespace Problems.Chapter8 
{
    // Triple Step
    public class Problem1 
    {
        public static int CountWays(int steps, IDictionary<int, int> knownWays) 
        {
            if (steps < 0)
                return 0;
            if (steps == 0)
                return 1;

            if (knownWays.ContainsKey(steps))
                return knownWays[steps];

            var waysFromHere = CountWays(steps - 1, knownWays) +
                               CountWays(steps - 2, knownWays) + 
                               CountWays(steps - 3, knownWays);
            knownWays.Add(steps, waysFromHere);

            return waysFromHere;
        }
    }
}