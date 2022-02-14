using System;

namespace Animal
{
  class Prog
  {
    static void Main_exe(string[] args)
    {
      Animal myCat = new Cat();
      Animal myDog = new Dog();

      myCat.animalSound();
      myDog.animalSound();
    }
  }
}