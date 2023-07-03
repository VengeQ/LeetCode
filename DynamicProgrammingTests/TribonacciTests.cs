using LeetCode.DynamicProgramming;
using NUnit.Framework;
using System;

namespace DynamicProgrammingTests
{
    public class TribonacciTests
    {
        private TribonacciNumber.Solution? _tribonacciNumberSolution;

        [SetUp]
        public void Setup()
        {
            _tribonacciNumberSolution = new TribonacciNumber.Solution();
        }

        [TearDown]
        public void TearDown()
        {
            _tribonacciNumberSolution = null;
        }

        [Test]
        [TestCase(-100)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void Tribonacci_WhenInputLessThanZero_ShouldThrowException(int input)
        {
            var exception = Assert.Throws<ArgumentException>(() => _tribonacciNumberSolution!.Tribonacci(input));
            Assert.That(exception!.Message, Does.StartWith("n should be between 0 and 37"));
        }

        [Test]
        [TestCase(38)]
        [TestCase(80)]
        [TestCase(int.MaxValue)]
        public void Tribonacci_WhenInputMoreThan37_ShouldThrowException(int input)
        {
            var exception = Assert.Throws<ArgumentException>(() => _tribonacciNumberSolution!.Tribonacci(input));
            Assert.That(exception!.Message, Does.StartWith("n should be between 0 and 37"));
        }

        [Test]
        public void Tribonacci_InputValue4_Returns4()
        {
            var expected = 4;
            var actual = _tribonacciNumberSolution!.Tribonacci(4);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void Tribonacci_InputValue25_Returns4()
        {
            var expected = 1389537;
            var actual = _tribonacciNumberSolution!.Tribonacci(25);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
