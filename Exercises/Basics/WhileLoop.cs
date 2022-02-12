using System;

namespace MyApp
{
    class WhileLoops
    {
        static void WhileLoop(string[] args)
        {
            int i = 0;
            
            while (i < 5) 
            {
            Console.WriteLine(i);
            i++;
            }
        }

        static void DoWhileLoop(string[] args)
        {
            int i = 0;

            do{
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
    }
}
