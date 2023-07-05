using LeetCode.DynamicProgramming;
using NUnit.Framework;
using System;

namespace DynamicProgrammingTests
{
    [TestFixture]
    public class MinCostClimbingStairsTests
    {
        [Test]
        public void MinimalCost_ArrayLengthLessThan2_ThrowException()
        {
            var ex = Assert.Throws<ArgumentException>(() =>CreateSolution().MinCostClimbingStairs(new int[] { 1 }));

            Assert.That(ex!.Message, Does.StartWith("Длина входного массива должна быть больше 1."));
        }

        [Test]
        public void MinimalCost_ArrayLengthMoreThan1000_ThrowException()
        {
            var ex = Assert.Throws<ArgumentException>(() => CreateSolution().MinCostClimbingStairs(new int[1001]));

            Assert.That(ex!.Message, Does.StartWith("Длина входного массива должна быть меньше 1000."));
        }

        [Test]
        public void MinimalCost_ArrayLengthEqualTwo_ShouldPass()
        {
            CreateSolution().MinCostClimbingStairs(new int[2]);

            Assert.Pass();
        }

        [Test]
        public void MinimalCost_ArrayLengthEqual1000_ShouldPass()
        {
            CreateSolution().MinCostClimbingStairs(new int[1000]);

            Assert.Pass();
        }

        [TestCase(new int[] { 10, 15, 20 }, 15)]
        [TestCase(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
        public void MinimalCost_ValidInputArray_ShouldReturnMinimalCost(int[] input, int result)
        {
            var minimalCost = CreateSolution().MinCostClimbingStairs(input);

            Assert.That(result, Is.EqualTo(minimalCost));
        }


        private static MinCostClimbingStairs.Solution CreateSolution() => new();
    }
}
