using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/train/csharp

namespace CodeWars.LevelSix;

public class SplitStrings
{
  public static string[] SplitString(string str)
  {
    if (str.Length % 2 == 1)
      str += "_";

    return Enumerable.Range(0, str.Length / 2)
                     .Select(i => str.Substring(i * 2, 2))
                     .ToArray();
  }
  public static string[] SplitStringV1(string str)
  {    
    if (str.Length % 2 == 1)
      str += "_";

    string[] result = new string[str.Length/2];

    for (int i = 0; i < result.Length; i++)
    {
      result[i] = str.Substring(i*2, 2);
    }

    return result;
  }
}
