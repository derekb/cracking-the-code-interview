using Xunit;
using Problems.Chapter8;
using System.Collections.Generic;

namespace Problems.Chapter8.Tests
{
    public class Problem1Test
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        public void N_Steps_ShoudHave_M_Ways(int steps, int ways)
        {
            Assert.Equal(ways, Problem1.CountWays(steps, new Dictionary<int, int>()));
        }
    }
}