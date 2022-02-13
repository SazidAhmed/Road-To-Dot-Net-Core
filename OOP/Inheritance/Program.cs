using System;

namespace Vehicle
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.Speed();
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}