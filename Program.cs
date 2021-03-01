using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lecture
{
    class Program
    {
        public static void Main(string[] args)
        {
            ForLoop.BasicLoop();
            //ForLoop.AddingNumbers();
            //ForLoop.MultipleInitializations();
            //ForLoop.WithoutInitializationAndIterator();
            //ForLoop.FirstInfinite();
            //ForLoop.SecondInfinite();
            //ForLoop.ThirdInfinite();

            int[] numbers = new int[] { 23, 45, 12, 111, 10, 67, 99 };
            //ForEachLoop.BasicLoop(numbers);
            //Console.WriteLine(ForEachLoop.SumOfNumbers(numbers));
            //Console.WriteLine(ForEachLoop.FindMaxNumber(numbers));

            //DoWhile.ShowDifference();
            //Nested.Sorting();

            //ExceptionsHandling.SimpleHandling();
            //ExceptionsHandling.WillFinallyWork();
            //Console.WriteLine(ExceptionsHandling.ReturnWithExceptions());
            //Console.WriteLine(ExceptionsHandling.GetValueFromArray(numbers, 3));
            //Console.WriteLine(ExceptionsHandling.GetValueFromArray(numbers, 11));
            //ExceptionsHandling.CatchWhen();
        }
    }
}
