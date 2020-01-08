using System;
using System.Collections.Generic;

namespace MiniMaxer.Library
{
    public class Helper
    {
        public static List<int> NormalizeInput (string input)
        {
            string[] inputAsArray = input.Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputAsArray.Length];
            List<int> valuesList = new List<int>();
            foreach (var value in inputAsArray)
            {
                try {
                    int number = int.Parse(value);
                    valuesList.Add(number);
                } catch (FormatException) {
                    Console.WriteLine("{0}: Bad Format", value);
                    return new List<int>();
                } catch (OverflowException) {
                    Console.WriteLine("{0}: Overflow", value);
                    return new List<int>();
                }
            }
            return valuesList;
        }
    }
}
