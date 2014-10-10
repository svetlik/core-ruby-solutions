using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Taylor
{
    public class Calculate
    {
        // Taylor Series

        //Because we know you love your calculus classes, we present you the final of our Y U GIVE US SOME MUCH MATH series with the, ahem, Taylor series.

        //In mathematics, a Taylor series is a representation of a function as an infinite sum of terms that are calculated from the values of the function's derivatives at a single point. It is common practice to approximate a function by using a finite number of terms of its Taylor series.

        //In particular, you can easily calculate common trigonometric functions. And that's want we want you to do. Calculate Sine and Cosine using their respective Taylor series. You can find them here.

        //The interface for the Sine and Cosine functions should be sine(x, precision) and cosine(x, precision), where precision is the upper limit of n. The higher the precision is, the better the approximation.

        public static long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        // calculating input degrees to radians
        public static double ToRadians(int degrees)
        {
            double radians = Math.PI * degrees / 180;

            return radians;
        }

        public static double Sine(int x, int precision)
        {
            double result = 0;

            for (int i = 0; i <= precision; i++)
            {
                double a = Math.Pow(-1, i);
                double b = Math.Pow(ToRadians(x), 2 * i + 1);
                double c = Factorial(2 * i + 1);
                result += a * b / c;
            }
            return result;

        }

        public static double Cosine(int x, int precision)
        {
            double result = 0;

            for (int i = 0; i <= precision; i++)
            {
                double a = Math.Pow(-1, i);
                double b = Math.Pow(ToRadians(x), 2 * i);
                double c = Factorial(2 * i);
                result += (a * b) / c;
            }
            return result;
        }


        static void Main(string[] args)
        {
            // some tests

            Console.WriteLine("Sine of 60 degrees: {0:0.00000}", Sine(60, 3));
            //Console.WriteLine("Sine of 60 degrees: {0:0.00000}", Sine(60, 15));

            //Console.WriteLine("Cosine 30 degrees: {0:0.00000}", Cosine(30, 2));

            //Console.WriteLine("Sine 90 degrees: {0:0.00000}", Sine(90, 10));
            //Console.WriteLine("Cosine of 90 degrees: {0:0.00000}", Cosine(90, 3));

            //Console.WriteLine("Cosine of 0 degrees: {0:0.00000}", Cosine(0, 3));
            //Console.WriteLine("Sine of 0 degrees: {0:0.00000}", Sine(0, 3));

        }
    }
}
