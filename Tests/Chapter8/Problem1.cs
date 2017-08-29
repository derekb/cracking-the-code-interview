using Xunit;
using Problems.Chapter8;

namespace Problems.Chapter8.Tests
{
    public class Problem1Test
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        public void N_Steps_ShoudHave_M_Ways(int steps, int ways)
        {
            Assert.Equal(ways, Problem1.CountStepsByOneTwoThree(steps));
        }
    }
}