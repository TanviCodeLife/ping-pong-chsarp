using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    // [TestMethod]
    // public void IsInteger_InputIsAInteger_False()
    // {
    //   NumberRange checkDivisibility = new NumberRange();
    //   Assert.AreEqual(false, checkDivisibility.IsInteger("1"));
    // }

    [TestMethod]
    public void CheckDivisibility_DivisibleByFifteen_True()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual(true, checkDivisibility.CheckDivisibility(15));
    }

    [TestMethod]
    public void CheckDivisibility_DivisibleByFive_True()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual(true, checkDivisibility.CheckDivisibility(5));
    }

    [TestMethod]
    public void CheckDivisibility_DivisibleByThree_True()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual(true, checkDivisibility.CheckDivisibility(3));
    }
  }
}
