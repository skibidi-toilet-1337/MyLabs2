using System;

namespace myApp {
  internal class Program {
    static void Main(string[] args) {
      int a, n, result;
      int x, n2;

      // First task
      Console.Write("First task\nEnter a: ");
      a = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter n: ");
      n = Convert.ToInt32(Console.ReadLine());

      result = pow(a, n);
      Console.WriteLine("Your result: " + result + "\n");

      //Second task
      while (true) {
        Console.Write("Second task\nEnter x (x >= 100): ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x >= 100) {
          break;
        }
        Console.WriteLine("Please try again, x must be >= 100:");
      }

      n2 = newNum(x);
      Console.WriteLine("Your n: " + n2);

    }

    static int pow(int a, int n) {
      int powResult = 1;

      for (int iteration = 0; iteration < n; ++iteration) {
        powResult *= a;
      }
      return powResult;
    }

    static int newNum(int x) {
      string strX;
      char secondDigit;
      string newNumber;

      strX = x.ToString();
      secondDigit = strX[1];
      newNumber = strX.Remove(1, 1);
      newNumber += secondDigit;

      return Convert.ToInt32(newNumber);
    }

  }
}