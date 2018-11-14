using System;
using System.Collections.Generic;

namespace PingPong
{
  public class NumberRange
  {
    // public bool IsInteger(string input)
    // {
    //   int outPut = 0;
    //   bool val = int.TryParse(input, out outPut);
    //   return val;
    // }


    public List<string> CreateNumberPingPongList(int inputNumb)
    {
      List<string> numberRange = new List<string> {};

      for (int index = 0; index < inputNumb; index++)
      {
        string inputAsString = this.CheckDivisibility(index + 1);
        numberRange.Add(inputAsString);
      }
      return numberRange;
    } 

    public string CheckDivisibility(int inputNumb)
    {

      if(inputNumb % 15 == 0)
      {
        return "ping-pong";
      }
      else if (inputNumb % 5 == 0)
      {
        return "pong";
      }
      else if (inputNumb % 3 == 0)
      {
        return "ping";
      }
      else
      {
        return inputNumb.ToString();
      }
    }

  }
}
