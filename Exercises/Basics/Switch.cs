using System;

namespace MyApp
{
    class Switchs
    {
        static void Switch_exe(string[] args)
        {
            string paymentMethod = "ada";

            switch(paymentMethod){
                case "ada":
                    Console.WriteLine("Cardano");
                    break;
                case "eth":
                    Console.WriteLine("Etherium");
                    break;
                default:
                    Console.WriteLine("Cash");
                    break;
            }
        }
    }
}
