using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeShifting.Models;

namespace PrimeShifting.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void NumberListConstructor_CreatesInstanceOfNumberList_NumberList()
    {
      NumberList newNumberList = new NumberList(10);
      Assert.AreEqual(typeof(NumberList), newNumberList.GetType());
    }
  }
}