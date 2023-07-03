using LeetCode.DynamicProgramming;
using NUnit.Framework;

namespace DynamicProgrammingTests
{
    public class FibonacciTests
    {
        [Test]
        public void FibonacciNumber_InputValue2_Returns1()
        {
            var expected = 1;

            var actual = CreateSolution().Fib(2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FibonacciNumber_InputValue3_Returns2()
        {
            var expected = 2;

            var actual = CreateSolution().Fib(3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FibonacciNumber_InputValue4_Returns3()
        {
            var expected = 3;

            var actual = CreateSolution().Fib(4);

            Assert.AreEqual(expected, actual);
        }

        private static FibonacciNumber.Solution CreateSolution() => new();
    }
}
