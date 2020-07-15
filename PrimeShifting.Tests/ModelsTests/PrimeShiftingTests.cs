using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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

      [TestMethod]
    public void NumberListConstructor_DisplaysFromTwoToInput_True()
    {
      NumberList newNumberList = new NumberList(10);
      Assert.AreEqual(9, newNumberList.InputNumberList.Count);
    }
  }
}