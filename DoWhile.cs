using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    class DoWhile
    {
        public static void ShowDifference()
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("While-Do");
                condition = false;
            }

            //condition = true;

            do
            {
                Console.WriteLine("Do-While");
                condition = false;
            } while (condition);
        }
    }
}
