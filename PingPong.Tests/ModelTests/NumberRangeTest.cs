using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
    public void CheckDivisibility_DivisibleByFifteen_Pingpong()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual("ping-pong", checkDivisibility.CheckDivisibility(15));
    }

    [TestMethod]
    public void CheckDivisibility_DivisibleByFive_Pong()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual("pong", checkDivisibility.CheckDivisibility(5));
    }

    [TestMethod]
    public void CheckDivisibility_DivisibleByThree_Ping()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual("ping", checkDivisibility.CheckDivisibility(3));
    }

    [TestMethod]
    public void CheckDivisibility_NotDivisbleByPreviousCriteria_True()
    {
      NumberRange checkDivisibility = new NumberRange();
      Assert.AreEqual("1", checkDivisibility.CheckDivisibility(1));
    }

    [TestMethod]
    public void CreateNumberPingPongList_CreatesListOfNumbersAndPingPongs_ExpectedList()
    {
      NumberRange testNewList = new NumberRange();

      CollectionAssert.AreEqual(new List<string> {"1", "2", "ping", "4", "pong"}, testNewList.CreateNumberPingPongList(5));
    }
  }
}
