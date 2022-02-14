
namespace Instruments
{
  class Instruments
  {
    static void Main_exe(string[] args)
    {
      Ibanez myGuitar = new Ibanez();
      myGuitar.brand();
      myGuitar.sound();

      Fender myBass = new Fender();
      myBass.brand();
      myBass.strings();
    }
  }
}