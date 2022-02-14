using System;

namespace Car
{
  class Car
  {
    public string model;
    public int maxSpeed;
    
    // Create a class constructor with a parameter
    public Car(string modelName, int speed)
    {
      model = modelName;
      maxSpeed = speed;
    }

    public void RunFast(string model, int maxSpeed)
    {
      Console.WriteLine(model + " runs more than " + maxSpeed + " kmph");
    }
  }
}