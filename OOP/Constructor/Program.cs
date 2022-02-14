using System;

namespace Car
{
  class Program
  {
    static void Main_exe(string[] args)
    {
      // Car Ford = new Car();
      // Ford.model = "Mustang";
      // Ford.maxSpeed = 200;
      // Console.WriteLine(Ford.model);
      // Console.WriteLine(Ford.maxSpeed);

      Car Audi = new Car("Audi", 250);
      Audi.RunFast(Audi.model, Audi.maxSpeed);
    }
  }
}