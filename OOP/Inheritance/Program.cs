using System;

namespace Vehicle
{
  class Prog
  {
    static void Main_exe(string[] args)
    {
      Car myCar = new Car();
      myCar.Speed();
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}