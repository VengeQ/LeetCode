using LeetCode.DynamicProgramming;
using NUnit.Framework;
using System;

namespace DynamicProgrammingTests
{
    public class TribonacciTests
    {
        [TestCase(-100)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        [Category("ExceptionTest")]
        public void Tribonacci_WhenInputLessThanZero_ShouldThrowArgumentException(int input)
        {
            var exception = Assert.Throws<ArgumentException>(() => CreateSolution().Tribonacci(input));

            Assert.That(exception!.Message, Does.StartWith("n should be between 0 and 37"));
        }

        [TestCase(38)]
        [TestCase(80)]
        [TestCase(int.MaxValue)]
        [Category("ExceptionTest")]
        public void Tribonacci_WhenInputMoreThan37_ShouldThrowArgumentException(int input)
        {
            var exception = Assert.Throws<ArgumentException>(() => CreateSolution().Tribonacci(input));

            Assert.That(exception!.Message, Does.StartWith("n should be between 0 and 37"));
        }

        [Test]
        [Category("GoodInputTest")]
        public void Tribonacci_InputValue4_Returns4()
        {
            var expected = 4;

            var actual = CreateSolution().Tribonacci(4);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        [Category("GoodInputTest")]
        public void Tribonacci_InputValue25_Returns1389537()
        {
            var expected = 1389537;

            var actual = CreateSolution().Tribonacci(25);

            Assert.That(actual, Is.EqualTo(expected));
        }

        private static TribonacciNumber.Solution CreateSolution() => new();
    }
}
