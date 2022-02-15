using System;

namespace GuitarStrings
{
  class Enums
  {
    static void Main_exe(string[] args)
    {
      Strings myGuitarStrings = Strings.Six;
      
      switch (myGuitarStrings){
        case Strings.Four:
          Console.WriteLine("My guitar has four strings");
          break;

        case Strings.Five:
          Console.WriteLine("My guitar has five strings");
          break;

        case Strings.Six:
          Console.WriteLine("My guitar has six strings");
          break;

        case Strings.Seven:
          Console.WriteLine("My guitar has seven strings");
          break;
      }
    }
  }
}