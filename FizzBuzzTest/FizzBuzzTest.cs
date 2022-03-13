using NUnit.Framework;

namespace FizzBuzzTest
{
    public class Tests
    {
               
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GivenANumberDivisibleByFive_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}