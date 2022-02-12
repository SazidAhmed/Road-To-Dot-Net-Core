using System;

namespace MyApp
{
    class Conditionals
    {
        static void IfElse_exe(string[] args)
        {
            bool programmer = true;
            bool doctor = false;

            if(doctor){
                Console.WriteLine("Doctor");
            }else if(programmer){
                Console.WriteLine("Programmer");
            }else{
                Console.WriteLine("Noob");
            }

            string result = (doctor ? "Doctor" : "Programmer");
            Console.WriteLine(result);
        }
    }
}
