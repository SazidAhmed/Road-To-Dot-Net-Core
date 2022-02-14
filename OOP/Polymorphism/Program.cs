
namespace Animal
{
  class Polymorp
  {
    static void Main_exe(string[] args)
    {
      Cat myCat = new Cat();
      Dog myDog = new Dog();

      myCat.animalSound();
      myDog.animalSound();
    }
  }
}