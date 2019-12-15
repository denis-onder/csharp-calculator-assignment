using System;

namespace csharp_calculator
{
  class Calculator
  {
    private int operand1;
    private int operand2;
    public Calculator(int operand1, int operand2)
    {
      this.operand1 = operand1;
      this.operand2 = operand2;
    }
    public string WriteText(string msg)
    {
      return msg;
    }
    public string WriteNumber()
    {
      return $"{this.operand1 + this.operand2}";
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Calculator c = new Calculator(53, 28); // Vrijednosti za racunanje se sada unose u konstruktor
      string s = c.WriteText("Hello world!");
      Console.WriteLine(s);
      string n = c.WriteNumber();
      Console.WriteLine(n);
      Console.Read();
    }
  }
}
