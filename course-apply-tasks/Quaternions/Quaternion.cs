using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Quaternions
{
    class Quaternion
    {
        //Quaternion (optional)

        //Quaternions are cool! They find uses in both theoretical and applied mathematics, in particular for calculations involving three-dimensional rotations such as in three-dimensional computer graphics and computer vision.

        //Choose an OOP language of your liking and design a Quaternion class implementing all of the properties by its definition.

        //Hint: you can name the component 1 as e.

        //The interface is up to you. How should you create a Quaternion? Should you override operators for Quaternion operations, if your language of choice supports it? Should you have any static properties? Why?

        //Please, answer all those question in a comment above the class definition.
        //Optional task

        //You can apply without solving this problem. But if you manage to solve it, this will help you in the interview process :)

        // QUESTION: How should you create a Quaternion?
        // ANSWER: A quaternion can be represented as follows: 
        // H = a.1 + b.i + c.j + d.k, where a, b, c, d are explicit real numbers
        // The "a.1" part of the quaternion is its scalar part, and the "b.i + c.j + d.k" part is its vector part. 
        // Programmatically a quaternion could be defined by two parameters - a scalar parameter and a vector parameter, which could be an object of a Vector3 class. Here, I choose not to use a Vector3 class, but to let the user define the vector part components b, c, and d. 
        // Quaternion (float a, float b, float c, float d)
        // TODO: a better alternative might be using a Complex structure

        // QUESTION: to override operators for operations? 
        // ANSWER: Yes, because we're dealing with complex numbers, which have a real and an imaginary values. So, for example, addition of complex numbers will require first the real components to be added and then the imaginary values to be added. Finally the result will be another complex number, with its special representation, for example: (a + bi) + (c + di) = (a + c) + (b + d)i. So, we won't be able to get such a result with the usual + operator. 

        // QUESTION: Should you have any static properties? Why?
        // ANSWER: The i, j, k imaginary units could be static. 

        // To implement:
        // Constructor - done
        // Conjugate - done
        // Sum - done
        // Product - done
        // Norm - done
        // Division
        // Matrix representations
        

        // Fields

        private float _a;
        private float _b;
        private float _c;
        private float _d;

        // Properties

        public float A
        {
            get { return _a; }
            set { _a = value; }
        }

        public float B
        {
            get { return _b; }
            set { _b = value; }
        }
        public float C
        {
            get { return _c; }
            set { _c = value; }
        }
        public float D
        {
            get { return _d; }
            set { _d = value; }
        }


        // Constructor
        public Quaternion()
        {

        }

        public Quaternion(float a, float b, float c, float d)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
        }

        // Overriden methods

        public override string ToString()
        {
            return String.Format("{0} + {1}i + {2}j + {3}k", this.A, this.B, this.C, this.D);
        }

        public static Quaternion operator +(Quaternion p, Quaternion q)
        {
            Quaternion result = new Quaternion();
            result.A = p.A + q.A;
            result.B = p.B + q.B;
            result.C = p.C + q.C;
            result.D = p.D + q.D;

            return result;
        }

        public static Quaternion operator *(Quaternion p, Quaternion q)
        {
            Quaternion result = new Quaternion();
            result.A = p.A * q.A - p.B * q.B - p.C * q.C - p.D * q.D;
            result.B = p.A * q.B + p.B * q.A + p.C * q.D - p.D * q.C;
            result.C = p.A * q.C - p.B * q.D + p.C * q.A + p.D * q.B;
            result.D = p.A * q.D + p.B * q.C - p.C * q.B + p.D * q.A;

            return result;
        }

        // Methods

        public static string Conjugate(Quaternion q)
        {
            return String.Format("{0} - {1}i - {2}j - {3}k", q.A, q.B, q.C, q.D);
        }

        public static float Norm(Quaternion q)
        {
            float n = (float)Math.Sqrt(q.A * q.A + q.B * q.B + q.C * q.C + q.D * q.D);
            return n;
        }

        static void Main(string[] args)
        {
            Quaternion h = new Quaternion(2.3f, 4.5f, 5.3f, 4.3f);
            Console.WriteLine(h);

            Quaternion q = new Quaternion(1.5f, 6.2f, 6.4f, 4.3f);
            Console.WriteLine("\nSum of quaternions: \n{0} \n{1} \nequals \n{2}", h, q, h + q);

            Console.WriteLine("\nProduct of quaternions: \n{0} \n{1} \nequals \n{2}", h, q, h * q);

            Console.WriteLine("\nConjugate of quaternion: \n{0} is \n{1}", h, Conjugate(h));

            Console.WriteLine("\nNorm of quaternion: \n{0} is \n{1}", h, Norm(h));

        }
    }
}
