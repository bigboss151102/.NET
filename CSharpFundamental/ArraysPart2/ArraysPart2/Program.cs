using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, };

            //Length()
            Console.WriteLine("Lenth: " + numbers.Length);

            // IndexOf()

            int index = Array.IndexOf(numbers,1);
            Console.WriteLine("Index of 1: " + index);

            // Clear()
            Array.Clear(numbers,0,2);
            Console.WriteLine("Effect of Clear()");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Coppy()

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Coppy()");
            foreach (int i in another)
            {
                Console.WriteLine(i);
            }

            //Sort()

            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Rverse()");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}