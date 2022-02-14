using System;
namespace Instruments{
    class Ibanez : IGuitar{

        public void brand(){
            Console.WriteLine("Ibanez guitar!");
        }
        public void sound(){
            Console.WriteLine("Sounds Awesome!");
        }
    }
}