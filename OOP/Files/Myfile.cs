using System;
using System.IO;

namespace MyFiles
{
  class FileRW
  {
    static void Main_exe(string[] args)
    {
      string writeText = "Hello World!";
      File.WriteAllText("filename.txt", writeText);

      string readText = File.ReadAllText("filename.txt");
      Console.WriteLine(readText);
    }
  }
}