using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class ArrayDifference
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(num => !b.Contains(num)).ToArray();
  }

  public static int[] ArrayDiffV2(int[] a, int[] b)
  {    
    List<int> newList = new();

    for (int i = 0; i < a.Length; i++)
    {
      if (!b.Contains(a[i]))
      {
        newList.Add(a[i]);
      }
    }
    return newList.ToArray();
  }
}
