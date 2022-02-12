using System;

namespace Car
{
  class Program
  {
    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.maxSpeed = 200;
        Console.WriteLine(Ford.model);
        Console.WriteLine(Ford.maxSpeed);

        Car Audi = new Car();
        Audi.model = "Audi";
        Audi.maxSpeed = 250;
        Console.WriteLine(Audi.model);
        Console.WriteLine(Audi.maxSpeed);
        Audi.RunFast(Audi.model);
    }
  }
}