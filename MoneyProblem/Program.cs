using System;
using System.Text;

namespace Week3;

public class MoneyProblem
{
    static void Main()
    {
        decimal money = 347.47m;
        int leftSide = (int)money;
        decimal rightSide = money - leftSide;
        Console.WriteLine(leftSide);
        Console.WriteLine(rightSide);
        Console.WriteLine(SolveMoneyProblems(347.47m));
    }

    private static string SolveMoneyProblems(decimal money)
    {
        StringBuilder sb = new();

        int countFifty = (int)money / 50;
        decimal remaining = money - countFifty * 50;

        int countTwenty = (int)remaining / 20;
        remaining -= countTwenty * 20;

        int countTen = (int)remaining / 10;
        remaining -= countTen * 10;

        int countFive = (int)remaining / 5;
        remaining -= countFive * 5;

        int countTwo = (int)remaining / 2;
        remaining -= countTwo * 2;

        int countOne = (int)remaining / 1;

        return sb.Append($"- {countFifty} '£50'\n")
            .Append($"- {countTwenty} '£20'\n")
            .Append($"- {countTen} '£10'\n")
            .Append($"- {countFive} '£5'\n")
            .Append($"- {countTwo} '£2'\n")
            .Append($"- {countOne} '£1'\n")
            .ToString();
    }
}