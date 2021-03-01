using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    class ForEachLoop
    {
        public static void BasicLoop(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int SumOfNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static int FindMaxNumber(int[] numbers)
        {
            int maxSoFar = numbers[0];
            foreach (int num in numbers)
            {
                if (num > maxSoFar)
                {
                    maxSoFar = num;
                }
            }
            return maxSoFar;
        }
    }
}
