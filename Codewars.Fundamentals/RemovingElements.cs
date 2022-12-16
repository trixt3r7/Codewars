using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// ## INSTRUCTIONS ##
// Take an array and remove every second element from the array.
// Always keep the first element and start removing with the next element.

namespace Codewars.Fundamentals
{
  public class RemovingElements
  {
    public static object[] RemoveEveryOther(object[] arr)
    {
      return arr.Where((item, index) => index % 2 == 0).ToArray();
    }

    public static object[] RemoveEveryOtherV1(object[] arr)
    {
      List<object> result = new List<object>();
      for (int i = 0; i < arr.Length; i++)
      {
        if (i % 2 == 0)
        {
          result.Add(arr[i]);
        }
      }
      return result.ToArray();
    }
  }
}
