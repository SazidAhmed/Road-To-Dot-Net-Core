﻿using System;

namespace MyApp
{
    class WhileLoop
    {
        static void Main(string[] args)
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
