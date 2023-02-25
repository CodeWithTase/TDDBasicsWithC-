using FizzBuzz.Library;
using NUnit.Framework;
using System;

namespace FizzBuzzyTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Buzzy_WhenDefault_ReturnsInput([Values(1,2,4,7,8,11,13, 14,16,17)]int input)
        {
            var expected = Convert.ToString(input);

            var result = FizzBuzzy.GetValue(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Buzzy_WhenDivisibleBy3_ReturnsFizz([Values(3,6,9,12,18)] int input)
        {
            var expected = "Fizz";

            var result = FizzBuzzy.GetValue(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Buzzy_WhenDivisibleBy5_ReturnsBuzz([Values(5, 10,20)] int input)
        {
            var expected = "Buzz";

            var result = FizzBuzzy.GetValue(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Buzzy_WhenDivisibleBy3And5_ReturnsFizzBuzz([Values(15)] int input)
        {
            var expected = "FizzBuzz";

            var result = FizzBuzzy.GetValue(input);

            Assert.AreEqual(expected, result);
        }
    }
}