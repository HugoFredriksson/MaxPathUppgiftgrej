using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");
        
        int[][] paths = new int[input.Length][];

        for (int i = 0; i < input.Length; i++)
        {
            string[] numbers = input[i].Split(' ');
            paths[i] = new int[numbers.Length];

            for (int j = 0; j < numbers.Length; j++)
            {
                paths[i][j] = int.Parse(numbers[j]);
            }
        }

        for (int i = paths.Length - 2; i >= 0; i--)
        {
            for (int j = 0; j < paths[i].Length; j++)
            {
                paths[i][j] += Math.Max(paths[i + 1][j], paths[i + 1][j + 1]);
            }
        }

        Console.WriteLine(paths[0][0]);
    }
}
