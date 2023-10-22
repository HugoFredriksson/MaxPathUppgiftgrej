using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the contents of "input.txt" into an array of strings
        string[] input = File.ReadAllLines("input.txt");

        // Create a 2D array to store the numbers
        int[][] paths = new int[input.Length][];

        // Split each line of input and parse it into integers
        for (int i = 0; i < input.Length; i++)
        {
            string[] numbers = input[i].Split(' ');
            paths[i] = new int[numbers.Length];

            for (int j = 0; j < numbers.Length; j++)
            {
                paths[i][j] = int.Parse(numbers[j]);
            }
        }

        // Calculate the maximum path sum
        for (int i = paths.Length - 2; i >= 0; i--)
        {
            for (int j = 0; j < paths[i].Length; j++)
            {
                paths[i][j] += Math.Max(paths[i + 1][j], paths[i + 1][j + 1]);
            }
        }

        // The maximum path sum will be in paths[0][0]
        Console.WriteLine(paths[0][0]);
    }
}