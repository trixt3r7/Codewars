using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelFour;

public class RangeExtraction
{
  public static string Extract(int[] args)
  {
    return string.Join(",", args
          .Select((value, index) => 
                  (value, args[Math.Min(args.Length - 1, index + 1)] - value != 1 
                  ? args[0]++ 
                  : args[0]))
          .GroupBy(x => x.Item2, x => x.Item1)
          .Select(x => x.Count() == 1 
                  ? $"{x.ElementAt(0)}" 
                  : $"{x.Min()}{(x.Count() > 2 ? "-" : ",")}{x.Max()}"));
  }

  public static string ExtractV2(int[] args)
  {
    int length = args.Length;

    List<string> result = new List<string>();

    for (int i = 0; i < length; i++)
    {
      // List populated with elements to later check Count is above 2
      // Add first value directly
      List<int> rangeList = new List<int>() { args[i] };

      // Loop until next value isn't +1
      while (i < length - 1 && args[i] + 1 == args[i + 1])
      {
        rangeList.Add(args[++i]);
        continue;
      }

      // If rangeList count is higher then 2 combine else each element seperate
      if (rangeList.Count > 2)
      {
        result.Add($"{rangeList[0]}-{rangeList[^1]}");
      }
      else
      {
        foreach (var n in rangeList)
        {
          result.Add(n.ToString());
        }
      }
    }

    // Finally Join the result to a string
    return string.Join(",", result);
  }

  public static string ExtractV1(int[] args)
  {
    int length = args.Length;

    //if (length < 2)
    //{
    //  return args[0].ToString();
    //}

    List<string> result = new List<string>();

    for (int i = 0; i < length; i++)
    {
      // List populated with elements to later check Count is above 2
      List<int> rangeList = new List<int>();

      // value to go to next element and value
      int next = 1;

      // Always start to add first element
      rangeList.Add(args[i]);

      // Single end element
      if (i + next >= length)
      {
        result.Add(rangeList[0].ToString());
        continue;
      }       

      // Loop until next value isn't +1
      while (args[i] + next == args[i + next])
      {
        rangeList.Add(args[i + next]);        
        next++;

        // If position gets IndexOutOfRange break
        if (i+next >= length)
        {
          break;
        }
      }

      // Change 'i' current position value
      i += (next - 1);

      // If rangeList count is higher then 2 combine else each element seperate
      if (rangeList.Count > 2)
      {
        result.Add($"{rangeList[0]}-{rangeList[^1]}");
      }
      else
      {
        foreach (var n in rangeList)
        {
          result.Add(n.ToString());
        }
      }
    }

    // Finally Join the result to a string
    return string.Join(",", result);
  }
}
