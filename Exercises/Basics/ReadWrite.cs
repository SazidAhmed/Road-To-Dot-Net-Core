using System;

namespace Basic
{
    class ReadWrite
    {
        static void Read_Write(string[] args)
        {
            Console.WriteLine("Enter a tile : ");
            string title = Console.ReadLine();
            Console.WriteLine("Title is : " + title);

            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is : " + num);
        }
    }
}
