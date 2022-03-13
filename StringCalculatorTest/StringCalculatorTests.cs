using NUnit.Framework;
using System;

namespace Week3;

public class StringCalculatorTests
{
    [TestCase("", 0)]
    [TestCase(" ", 0)]
    [TestCase("1", 1)]
    [TestCase("1,2", 3)]
    [TestCase("1 , 2 ", 3)]
    [TestCase("1 , 1 ", 2)]
    [TestCase("1 , 2,3,4 ", 10)]
    [TestCase("1 , 2," +
        "3,4 ", 10)]
    [TestCase("1 , 2\n 3,4 ", 10)]
    [TestCase("//;\n1;2", 3)]
    [TestCase("1001 , 2 ", 2)]
    [TestCase("//[***]\n1***2***3", 6)]
    [TestCase("//[-----]\n1-----2-----3", 6)]
    [TestCase("//[***][%%][----]\n1***2%%3----4", 10)]
    public void ShouldReturn_CorrectTotal(string input, int expectedResult)
    {
        Assert.That(StringCalculator.Calculate(input), Is.EqualTo(expectedResult));
    }

    [TestCase("1, -1")]
    public void ShouldThrowException_WhenGivenOneNegativeNumber(string input)
    {
        Assert.That(() => StringCalculator.Calculate(input),
            Throws.TypeOf<ArgumentException>()
            .With.Message.Contain("-1"));
    }

    [TestCase("-1, 11, -5, 11, 21, -11, -1")]
    public void ShouldThrowException_WhenGivenMultipleNegativeNumbers(string input)
    {
        Assert.That(() => StringCalculator.Calculate(input),
            Throws.TypeOf<ArgumentException>()
            .With.Message.Contain("-11, -5, -1"));
    }
}
