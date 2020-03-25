using System;

namespace SortByIserts
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool finishState = false;
            while (!finishState) {
                Console.WriteLine("Type an array lenght");
                int lenght = Convert.ToInt32(Console.ReadLine());

                int[] sequence = new int[lenght];

                for (int i = 0; i < sequence.Length; i++)
                {
                    Console.WriteLine("Type a value of array");
                    sequence[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 1; i < sequence.Length; i++)
                {
                    for (int j = i; j > 0 && sequence[j - 1] > sequence[j]; j--)
                    {
                        int temp = sequence[j - 1];
                        sequence[j - 1] = sequence[j];
                        sequence[j] = temp;
                        counter++;
                    }
                }
                for (int i = 0; i < sequence.Length; i++)
                {
                    Console.WriteLine($"[array{i}] = {sequence[i]}");
                }
                Console.WriteLine($"Total number of replacing is {counter}");
                Console.WriteLine("Type a to finish the programm");
                if (Console.ReadLine() == "a")
                {
                    finishState = true;
                }
            }
        }
    }
}
