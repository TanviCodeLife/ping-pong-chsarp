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

    public bool CheckDivisibility(int inputNumb)
    {

      if(inputNumb % 15 == 0)
      {
        return true;
      }
      else if (inputNumb % 5 == 0)
      {
        return true;
      }
      else
      {
        return inputNumb % 3 == 0;
      }
    }

  }
}
