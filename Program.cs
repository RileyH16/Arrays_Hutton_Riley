using System;

namespace Arrays_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a whole number for the array size
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            //Sets the amount of numbers in the array
            for(int i = 0; i < numbers.Length; i++)
            {
                //Asks the user to enter more whole numbers
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            //Adds the numbers 
            Console.WriteLine($"The sum of the array is {sum}");

            //Sorts the numbers
            Array.Sort(numbers);

            Console.WriteLine("Array:");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
