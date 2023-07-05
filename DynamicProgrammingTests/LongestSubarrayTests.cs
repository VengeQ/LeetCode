using LeetCode.DynamicProgramming;
using NUnit.Framework;
using System;

namespace DynamicProgrammingTests
{
    public class LongestSubarrayTests
    {

        [Test]
        public void LongestSubarray_ArrayZeroLength_ThrowException()
        {
            var solution = CreateSolution();

            var ex = Assert.Throws<ArgumentException>(() => solution.LongestSubarray(Array.Empty<int>()));
            Assert.That(ex!.Message, Does.StartWith("Длина массива должна быть больше 0"));
        }

        [Test]
        public void LongestSubarray_ArrayLengthMoreThan100000_ThrowException ()
        {
            var solution = CreateSolution();

            var ex = Assert.Throws<ArgumentException>(() => solution.LongestSubarray(new int[100001]));
            Assert.That(ex!.Message, Does.StartWith("Длина массива не должна превышать 100000"));
        }


        [Test]
        public void LongestSubarray_NullInputArray_ThrowException()
        {
            var solution = CreateSolution();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            var ex = Assert.Throws<ArgumentNullException>(() => solution.LongestSubarray(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.That(ex!.Message, Does.StartWith("Входной параметр не должен быть равен нулю"));
        }

        [TestCase(new int[] { 1, 1, 0, 1 }, 3)]
        [TestCase(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
        [TestCase(new int[] { 1, 1, 1 }, 2)]
        public void LongestSubarray_ValidInputArray_ReturnLongestSubarraySize(int[] input, int expectedResult)
        {
            var actual = CreateSolution().LongestSubarray(input);

            Assert.That(actual, Is.EqualTo(expectedResult));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0, 1, int.MaxValue })]
        [TestCase(new int[] { 0, 1, -1 })]
        [TestCase(new int[] { 1, 1, int.MinValue })]
        public void LongestSubarray_NotZeroOrNotOneElementInArray_ThrowException(int[] input)
        {
            var solution = CreateSolution();

            var ex = Assert.Throws<ArgumentException>(() => solution.LongestSubarray(input));
            Assert.That(ex!.Message, Does.StartWith("Во входном массиве все элементы должны быть 0 или 1"));
        }

        private static LongestSubarray.Solution CreateSolution() => new();
    }
}
