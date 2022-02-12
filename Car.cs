using System;

namespace Car
{
  class Car
  {
    public string model;
    public int maxSpeed;
    
    public void RunFast(string model)
    {
        Console.WriteLine(model + " runs so fast!");
    }
  }
}