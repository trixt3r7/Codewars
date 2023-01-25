using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelFive;

public class MissingLetter
{
  public static char FindMissingLetterV3(char[] array)
  {
    return (char)(array.Where((c, i) => array[i + 1] - c != 1).First() + 1);
  }
  public static char FindMissingLetter(char[] array)
  {
    return (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));
  }
  public static char FindMissingLetterV1(char[] array)
  {
    char prev = array[0];
    foreach (char c in array)
    {
      if (c != prev)
      {
        break;
      }
      prev++;
    }
    return prev++;
  }
}
