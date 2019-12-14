using System;

namespace csharp_calculator
{
  class Calculator
  {
    public static string WriteText(string msg)
    {
      return msg;
    }
    public static string WriteNumber(int x)
    {
      return x.ToString();
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      string s = Calculator.WriteText("Hello world!");
      Console.WriteLine(s);
      string n = Calculator.WriteNumber(53 + 28);
      Console.WriteLine(n);
      Console.Read();
    }
  }
}
