using System;

namespace Human
{
  abstract class Human
  {
    public abstract void eat();

    public void walk(){
      Console.WriteLine("Walks slow");
    }
  }
}