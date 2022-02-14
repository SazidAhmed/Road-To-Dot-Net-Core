using System;
namespace Instruments{
    class Fender : IBass{

        public void brand(){
            Console.WriteLine("Fender Bass!");
        }
        public void strings(){
            Console.WriteLine("5 Strings!");
        }
    }
}