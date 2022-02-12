using System;

namespace MyApp
{
    class Bools
    {
        static void Bools_exe(string[] args)
        {
            bool programmer = true;
            bool doctor = false;

            Console.WriteLine("Programmer ? : " + programmer);
            Console.WriteLine("Doctor ? : " + doctor);

            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            Console.WriteLine(x == 10); 
        }
    }
}
