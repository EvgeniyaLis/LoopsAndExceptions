using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    class ForLoop
    {
        public static void BasicLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(String.Format("Iteration: {0}", i));
            }
        }

        public static void AddingNumbers()
        {
            int n = 5, sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i; // sum = sum + i; 
            }

            Console.WriteLine("Sum of first {0} natural numbers = {1}", n, sum);
        }

        public static void MultipleInitializations()
        {
            for (int i = 0, j = 0; i + j <= 5; i++, j++)
            {
                Console.WriteLine("i = {0} and j = {1}", i, j);
            }
        }

        public static void WithoutInitializationAndIterator()
        {
            int i = 1;
            for (; i <= 5;)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }
        }

        public static void FirstInfinite()
        {
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
            }
        }
        public static void SecondInfinite()
        {
            for (; ; )
            {
                Console.WriteLine("Second infinite loop");
            }
        }
        public static void ThirdInfinite()
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
            }
        }
    }
}
