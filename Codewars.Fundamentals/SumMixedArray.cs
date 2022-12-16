using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Fundamentals
{
  public class SumMixedArray
  {
    public static int SumMix(object[] x)
    {
      return x.Sum(Convert.ToInt32);
    }
    public static int SumMixV2(object[] x)
    {
      return x.Sum(i => int.Parse(i.ToString()!));
    }
    public static int SumMixv1(object[] x)
    {
      int sum = 0;
      foreach (object o in x)
      {
        if(Int32.TryParse((string)o, out int r))
        {
          sum += r;
        }
      }
      return sum;
    }
  }
}
