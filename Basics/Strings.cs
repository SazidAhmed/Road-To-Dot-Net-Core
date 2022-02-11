using System;

namespace MyApp
{
    class StringS
    {
        static void Strings_exe(string[] args)
        {
            string greet = "Hello ";
            string name = "Sazid";
            string name2 = "Ahmed";

            Console.WriteLine("The length is: " + name.Length);
            Console.WriteLine("The first character is: " + name[0]);
            Console.WriteLine("The index of letter is: " + greet.IndexOf("e")); 
            Console.WriteLine("The Substring is: " + name2.Substring(3));
            
            string welcome = greet + name;
            string greetings = string.Concat(greet, name);
            string helloSazid = $"Hi : {greet}{name}";
            Console.WriteLine(welcome);
            Console.WriteLine(greetings);
            Console.WriteLine(helloSazid);
        }
    }
}
