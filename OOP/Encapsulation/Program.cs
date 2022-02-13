using System;

namespace Category
{
  class Program
  {
    static void Main_exe(string[] args)
    {
      Category instruments = new Category();
      instruments.N = "Guitar";
      instruments.P = 200.50F;
      Console.WriteLine(instruments.N);
      Console.WriteLine(instruments.P);
    }
  }
}