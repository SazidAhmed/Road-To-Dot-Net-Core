using System;

namespace MyApp
{
    class BreakContinue
    {
        static void BreakContinue_exe(string[] args)
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            foreach (string i in cars) 
            {
                if(i == "Ford"){
                    break;
                }else{
                    Console.WriteLine(i);
                }
            }

            int[] num = {10, 20, 30, 40};

            for (int y=0; y<num.Length; y++) 
            {
                if(num[y] == 30){
                    continue;
                }else{
                    Console.WriteLine(num[y]);
                }
            }
        }
    }
}
