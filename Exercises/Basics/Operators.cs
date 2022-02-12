using System;

namespace MyApp
{
    class Operators
    {
        static void Oper(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number is : " + num1);
            Console.WriteLine("Second number is : " + num2);

            int sum = num1 + num2;
            int sub = num1 - num2;
            int div = num1 / num2;
            int mul = num1 * num2;

            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Sub is : " + sub);
            Console.WriteLine("Mul is : " + mul);
            Console.WriteLine("Div is : " + div);
            
        }
    }
}
