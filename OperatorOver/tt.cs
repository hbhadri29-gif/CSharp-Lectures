using System;
namespace MyApplication {
  class Program {
    static void Main(string[] args) {
      int n1 = 13;
      Type n2 = n1.GetType();
      double nD = n1;
      Type n3 = nD.GetType();
      Console.WriteLine("numInt value: "+n1);
      Console.WriteLine("numInt Type: " + n2);
      Console.WriteLine("numDouble value: "+nD);
      Console.WriteLine("numDouble Type: " + n3);
      Console.ReadLine();
    }
  }
}