using System;
using System.Linq;

namespace MyApp
{
    class MethodClass
    {
        static void MySelf(string fname, int age) 
        {
            Console.WriteLine("I am " + fname + " and I am " + age);
        }

        static int Sum(int x, int y) 
        {
            return x + y;
        }

        //Method overloading
        static double Sum(double x, double y) 
        {
            return x + y;
        }

        static float Sum(float x, float y) 
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            MySelf("Sazid", 28);
            int z = Sum(x:5, y:10);
            Console.WriteLine(z);

            Console.WriteLine(Sum(x:5.21, y:10.55));
            Console.WriteLine(Sum(x:5.2, y:10.5));
        }
    }
}
