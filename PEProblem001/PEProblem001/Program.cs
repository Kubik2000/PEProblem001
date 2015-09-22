using System;
/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 * The idea behind is to add the values of the numbers that meet the requirements to constructed field.
 * Once the field is filled now just count them up going through the field. There will be no duplicates.
 */
namespace PE_Problem_001
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int arraySize = 1000;

            int[] numbers = new int[arraySize];

            for (int i = 3; i < arraySize; i += 3)
            {
                numbers[i] = i;
            }

            for (int i = 5; i < arraySize; i += 5)
            {
                numbers[i] = i;
            }

            int result = 0;
            for (int i = 0; i < arraySize; i++)
            {
                result += numbers[i];
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
