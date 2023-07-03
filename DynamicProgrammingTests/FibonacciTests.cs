using LeetCode.DynamicProgramming;
using NUnit.Framework;

namespace DynamicProgrammingTests
{
    public class FibonacciTests
    {
        private FibonacciNumber.Solution? _fibonacciNumberSolution;

        [SetUp]
        public void Setup()
        {
            _fibonacciNumberSolution = new FibonacciNumber.Solution();
        }

        [TearDown]
        public void TearDown()
        {
            _fibonacciNumberSolution = null;
        }

        [Test]
        public void FibonacciNumber_InputValue2_Returns1()
        {
            var expected = 1;
            var actual = _fibonacciNumberSolution!.Fib(2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FibonacciNumber_InputValue3_Returns2()
        {
            var expected = 2;
            var actual = _fibonacciNumberSolution!.Fib(3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FibonacciNumber_InputValue4_Returns3()
        {
            var expected = 3;
            var actual = _fibonacciNumberSolution!.Fib(4);

            Assert.AreEqual(expected, actual);
        }
    }
}
