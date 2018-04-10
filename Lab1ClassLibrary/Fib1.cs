using System;

namespace Lab1ClassLibrary
{
    public class Fib1
    {
        public static int Len(String str)
        {
            return str.Length;
        }

        public static int FibonacciLength(String str)
        {
            int len = str.Length;
            return FibonacciNum(len);
        }

        static int FibonacciNum(int n)
        {
            if (n < 0) return -1;
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   

            int i = 2;
            while (n >= result)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
                i++;
                if (n == result)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
