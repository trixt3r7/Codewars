using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class PersistentBugger
{
  public static int Persistence(long n)
  {
    int counter = 0;
    while (n > 9)
    {
      n = n.ToString().Select(c => int.Parse(c.ToString()))
                      .Aggregate((x, y) => x * y);
      counter++;
    }

    return counter;
  }
  public static int PersistenceV2(long n)
  {
    int counter = 0;
    while (n > 9)
    {
      int[] numbers = n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
      n = numbers.Aggregate((x, y) => x * y);
      counter++;
    }

    return counter;
  }
  public static int PersistenceV1(long n)
  {
    int counter = 0;
    long sum = n;
    List<int> numbers = new List<int>();
    
    while (sum > 9)
    {
      numbers = n.ToString().Select(c => int.Parse(c.ToString())).ToList();
      sum = numbers[0];

      for (int i = 1; i < numbers.Count(); i++)
      {
        sum *= numbers[i];
      }
      counter++;
      n = sum;
    }

    return counter;
  }
}
