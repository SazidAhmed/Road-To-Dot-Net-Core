﻿using System;

namespace Item
{
  class Program
  {
    static void Main(string[] args)
    {
      Category instruments = new Category();
      instruments.N = "Guitar";
      instruments.P = 200.50F;
      Console.WriteLine(instruments.N);
      Console.WriteLine(instruments.P);
    }
  }
}