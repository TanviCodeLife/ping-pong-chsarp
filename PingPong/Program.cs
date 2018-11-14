using System;
using System.Collections.Generic;

namespace PingPong {

  class Program
  {

    static void Main()
    {
      Console.WriteLine("Enter a number to pingpong: ");
      string input = Console.ReadLine();

      int inputNumber = 0;
      bool isInteger = int.TryParse(input, out inputNumber);

      if (isInteger)
      {
        NumberRange newGame = new NumberRange();
        List<string> thisList = new List<string> {};
        thisList = newGame.CreateNumberPingPongList(inputNumber);

        foreach (string element in thisList)
        {
          Console.WriteLine(element);
        }
      }
      else
      {
        Console.WriteLine("Try again with a valid number!");
      }
    }

  }
}
