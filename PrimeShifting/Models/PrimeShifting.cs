using System.Collections.Generic;

namespace PrimeShifting.Models
{
  public class NumberList
  {
    public List<int> InputNumberList { get; set; }
    public NumberList(int input)
    {
      InputNumberList = new List<int>() {input};
      List<int> inputNumberList = InputNumberList;
    }
  }
}