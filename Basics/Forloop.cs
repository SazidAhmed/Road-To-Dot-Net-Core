using System;

namespace MyApp
{
    class ForLoop
    {
        static void ForLoop_exe(string[] args)
        {
            for (int i = 0; i <= 10; i = i + 2) {
                Console.WriteLine(i);
            }

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string car in cars) 
            {
                Console.WriteLine(car);
            }
        }
    }
}
