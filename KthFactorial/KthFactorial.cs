using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KthFactorial
{
    public class Program
    {
        // Kth Factorial

        //In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example:

        //5! = 5 * 4 * 3 * 2 * 1 = 120

        //To make things more interesting, we want you to find the kth factorial of any number n.

        //kth_factorial = (n!) * (n!) * (n!) ... k times

        //The interface of the function is kth_factorial(k, n). Think about the constraints of the types of input k and n parameters and the output of the whole function.

        // SOLUTION:

        // By definition, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. So in our case, n should be of a non-negative type; I've chosen byte.
        // We're having a positive number of factorials to multiply, so k should also be a positive integer; again, we should be fine with type byte.
        // To be on the safe side, the result will be of a BigInteger type, thus allowing us not to worry about maximum value of the Factorial of n.
        // TODO: to work on abstracting repetitive code

        public static BigInteger Factorial(byte n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static BigInteger kth_factorial(byte k, byte n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= k; i++)
            {
                result *= Factorial(n);
            }

            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(5));
            //Console.WriteLine(kth_factorial(0, 0));
            //Console.WriteLine(kth_factorial(0, 1));
            Console.WriteLine(kth_factorial(1, 6));

            //Console.WriteLine(kth_factorial(255, 255));

            if (Factorial(5) == 120)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            if (kth_factorial(3, 5) == 1728000)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
        }
    }
}