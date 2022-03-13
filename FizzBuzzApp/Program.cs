using System;

public class Program
{
    static void Main(string[] args)
    {
        int max = 30;
        
        for(int i = 0 ; i < max; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }

    }

    public static string FizzBuzz(int n)
    {
        if (n % 3 == 0)
        {
            if(n % 15 == 0)
            {
                return "FizzBuzz";
            }
            return "Fizz";
        }
        else if(n % 5 == 0)
        {
            return "Buzz";
        }
        return n.ToString();
    }
   
}