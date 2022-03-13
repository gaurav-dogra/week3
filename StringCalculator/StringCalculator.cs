using System;
using System.Text.RegularExpressions;

namespace Week3;

public class StringCalculator
{
    static void Main()
    {
    }

    public static int Calculate(string input)
    {
        input = input.Trim();
        if (String.IsNullOrEmpty(input))
            return 0;

        HashSet<char> delimeters = new();

        if (input.StartsWith("//["))
        {
            List<string> fullDelimeters = GetDelimeters(input);
            input = input[(input.IndexOf('\n') + 1)..];
            foreach (string s in fullDelimeters)
            {
                input = input.Replace(s, s[0].ToString());
                delimeters.Add(s[0]);
            }
        }
        else if (input.StartsWith("//"))
        {
            delimeters = new() { '\n', input[2] };
            input = input[(input.IndexOf('\n') + 1)..];
        } 
        else
        {
            delimeters.Add(',');
            delimeters.Add('\n');
        }

        string[] strSplitInArray = input.Split(delimeters.ToArray());

        return AddElements(strSplitInArray);
    }

    private static List<string> GetDelimeters(string str)
    {
        List<string> delimeters = new();
        string pattern = "\\[(.+?)\\]";
        Regex regex = new(pattern);
        Match match = regex.Match(str);
        while (match.Success)
        {
            Group group = match.Groups[1];
            delimeters.Add(group.Value);
            match = match.NextMatch();
        }
        return delimeters;
    }

    private static int AddElements(string[] strSplitInArray)
    {
        int sum = 0;
        SortedSet<int> negativeNumbers = new();

        foreach (string s in strSplitInArray)
        {
            bool isSucces = int.TryParse(s, out int number);
            if (number < 0 && isSucces)
                negativeNumbers.Add(number);
            else if (number <= 1000)
                sum += isSucces ? number : throw new ArgumentException("Input does not meet the specification");
        }

        if (negativeNumbers.Count > 0)
            throw new ArgumentException($"negatives not allowed but found {string.Join(", ", negativeNumbers)}");
        return sum;
    }
}
