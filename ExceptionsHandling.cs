using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    class ExceptionsHandling
    {
        public static void SimpleHandling()
        {
            try
            {
                throw new ArgumentException("Invalid argument");
            } 
            catch (ArgumentException exception)
            {
                Console.WriteLine("We caught exception! " + exception.Message);
            }
            finally
            {
                Console.WriteLine("Clean up in finally");
            }
            Console.WriteLine("After all blocks");
        }

        public static int ReturnWithExceptions()
        {
            try
            {
                throw new ArgumentException("Invalid argument");
                return 1;
            }
            catch
            {
                Console.WriteLine("In catch");
                return 2;
            }
            finally
            {
                Console.WriteLine("In finally");
            }
            return 3;
        }

        public static void WillFinallyWork()
        {
            try
            {
                Console.WriteLine("In try");
                throw new ArgumentException("Invalid argument");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("In catch");
                try { throw new ArgumentException("Invalid argument"); }
                catch { }
                finally { }
            }
            finally
            {
                Console.WriteLine("In finally");
            }
        }

        public static int GetValueFromArray(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ArgumentException("Index is out of range", nameof(index), ex);
            }
        }

        // Если нажать Продолжить, то программа заходит в метод LogException и все обрабатывается
        public static void CatchWhen()
        {
            try
            {
                throw new NullReferenceException("found null");
            }
            catch (NullReferenceException e) when (LogException(e))
            {
            }
            Console.WriteLine("Exception must have been handled");
        }

        private static bool LogException(Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.StackTrace);
            return true;
        }
    }
}
