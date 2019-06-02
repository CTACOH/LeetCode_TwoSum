using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode.TwoSum.Tests
{
    [TestClass]
    public class TwoSumSolutionTest
    {
        [TestMethod]
        public void TwoSum_Nums_Target9()
        {
            int[] nums = new int[] { 2, 7, 11, 12, 20 };
            int target = 9;
            int[] expected = new int[] { 0, 1 };

            TwoSumSolution solution = new TwoSumSolution();

            int[] result = solution.TwoSum(nums, target);

            Assert.IsTrue(result.SequenceEqual(expected));
        }

        [TestMethod]
        public void TwoSum_TwoIdenticalNumbers_Target6()
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;
            int[] expected = new int[] { 0, 1 };

            TwoSumSolution solution = new TwoSumSolution();

            int[] result = solution.TwoSum(nums, target);

            Assert.IsTrue(result.SequenceEqual(expected));
        }
    }
}
