using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsInteger_InputIsAInteger_False()
    {
      NumberRange testIsInteger = new NumberRange();
      Assert.AreEqual(false, testIsInteger.IsInteger("e"));
    }

  }
}
