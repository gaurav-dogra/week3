using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            StringBuilder sb = new("");

            for (int i = 0; i < num; i++)
            {
                if (queue.TryDequeue(out string element))
                    sb.Append(element).Append(", ");
                else
                    break;
            }

            return sb.Length == 0 ? String.Empty : sb.Remove(sb.Length - 2, 2).ToString();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> stack = PushArrayToStack(original);
            return PullArrayFromStack(stack);
        }

        private static int[] PullArrayFromStack(Stack<int> stack)
        {
            int length = stack.Count;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = stack.Pop();
            }
            return array;
        }

        private static Stack<int> PushArrayToStack(int[] original)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < original.Length; i++)
            {
                stack.Push(original[i]);
            }
            return stack;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {

            Dictionary<int, int> myDictionary = GetDigitsAndCountFromString(input);
            StringBuilder sb = new();
            foreach (KeyValuePair<int, int> entry in myDictionary)
            {
                sb.Append($"[{entry.Key}, {entry.Value}]");
            }
            return sb.ToString();
        }

        private static Dictionary<int, int> GetDigitsAndCountFromString(string input)
        {
            Dictionary<int, int> myDictionary = new();
            Regex regex = new("\\d");

            foreach (char c in input)
            {
                string charAsStr = c.ToString();

                if (regex.IsMatch(charAsStr))
                {
                    int n = int.Parse(charAsStr);

                    if (myDictionary.ContainsKey(n))
                        myDictionary[n] = ++myDictionary[n];
                    else
                        myDictionary.Add(n, 1);
                }
            }
            return myDictionary;
        }
    }
}
