using System;
namespace GoodbyeTree
{
  class OliverTree
  {
    static void Main()
    {
      bool OliverTreeIsAlive = false;
      if (!OliverTreeIsAlive)
      {
        Console.WriteLine("Rest in peace, Oliver Tree");
      }
      else
      {
        throw new InvalidOperationException(":(");
      }
    }
  }
}
