using System;
using System.Linq;

namespace MyApp
{
    class ArrayClass
    {
        static void Array_exe(string[] args)
        {
            string[] cars ;
            cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(cars);
            Console.WriteLine("Count is : " + cars.Length);

            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }

            int[] num = {10, 50, 20, 40, 30};
            Array.Sort(num);
            Console.WriteLine("Max is : " + num.Max());
            Console.WriteLine("Min is : " + num.Min());
            Console.WriteLine("Sum is : " + num.Sum()); 

            // foreach (int y in num) 
            // {
            //     Console.WriteLine(y);
            // }

            for (int y = 0; y < num.Length; y++) 
            {
                if(num[y] == 30){
                    num[y] = 35;
                    Console.WriteLine(num[y]);
                }else{
                    Console.WriteLine(num[y]);
                }
            }
        }
    }
}
