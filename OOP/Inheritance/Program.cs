using System;

namespace Vehicle
{
  class Inherit
  {
    static void Main_exe(string[] args)
    {
      Car myCar = new Car();
      myCar.Speed();
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}