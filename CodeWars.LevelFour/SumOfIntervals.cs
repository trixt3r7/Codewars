using System;
using System.Linq;

namespace CodeWars.LevelFour
{
  public class SumOfIntervals
  {
    public static int SumIntervals((int, int)[] intervals)
    {
      var prevMax = int.MinValue;

      return intervals
          .OrderBy(x => x.Item1)
          .ThenBy(x => x.Item2)
          .Aggregate(0, (acc, x) => acc += prevMax < x.Item2 ? -Math.Max(x.Item1, prevMax) + (prevMax = x.Item2) : 0);
    }

    public static int SumIntervalsV1((int, int)[] intervals)
    {
      if (intervals.Count() == 0)
      {
        return 0;
      }

      var intervalsSorted = intervals.OrderBy(t => t.Item1).ToList();      
      int sumIntervals = 0;
      int i = 0;
      int j = 0;
      
      while (i < intervalsSorted.Count)
      {
        sumIntervals += intervalsSorted[i].Item2 - intervalsSorted[i].Item1;
        
        j = i + 1;
        while (j < intervalsSorted.Count && intervalsSorted[i].Item2 >= intervalsSorted[j].Item2)
        {
          j++;
        }
        if(j < intervalsSorted.Count && (intervalsSorted[i].Item2 > intervalsSorted[j].Item1))
        {
          sumIntervals -= intervalsSorted[i].Item2 - intervalsSorted[j].Item1;
        }        
        i = j;
      }
      return sumIntervals;
    }
  }
}
