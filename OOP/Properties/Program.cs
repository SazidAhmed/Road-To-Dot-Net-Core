using System;

namespace Category
{
  class Props
  {
    static void Main_exe(string[] args)
    {
      Guitar myGuitar = new Guitar();
      myGuitar.N = "Guitar";
      myGuitar.P = 200.50F;
      Console.WriteLine(myGuitar.N);
      Console.WriteLine(myGuitar.P);
    }
  }
}