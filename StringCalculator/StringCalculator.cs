using System;
namespace Week3;

public class StringCalculator
{
    static void Main()
    {
        Console.WriteLine(Calculate("Test string"));
    }

    public static int Calculate(string str)
    {
        if (String.IsNullOrEmpty(str.Trim()))
            return 0;

        char[] delimeters = new char[2] {'\n', ','};

        if (str.StartsWith("//["))
        {
            string fullDelimeter = str.Substring(3, str.IndexOf("]") - 3);
            delimeters[1] = fullDelimeter[0];
            str = str[(str.IndexOf('\n') + 1)..];
            // assuming delimeter is a string of identical characaters
            str = str.Replace(fullDelimeter, fullDelimeter[0].ToString());
        }
        else if (str.StartsWith("//"))
        {
            delimeters[1] = str[2];
            str = str[(str.IndexOf('\n') + 1)..];
        }

        string[] strSplitInArray = str.Split(delimeters);

        return AddElements(strSplitInArray);
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
