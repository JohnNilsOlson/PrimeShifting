using System.Collections.Generic;

namespace PrimeShifting.Models
{
  public class NumberList
  {
    public List<int> InputNumberList { get; set; }
    public NumberList(int input)
    {
      InputNumberList = new List<int>() {input};
      int i = 2;
      while (i < input )
      {
        InputNumberList.Add(i);
        i ++;
      }
    }
  }
}