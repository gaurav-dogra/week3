using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> myList = new List<int>();

            for (int i = 5; i <= max; i += 5)
            {
                myList.Add(i);
            }
            return myList;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> myList = new List<string>();

            foreach (string str in sourceList)
            {
                if (str.StartsWith('a') || str.StartsWith('A'))
                    myList.Add(str);
            }
            return myList;
        }
    }
}
