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

    public static int SumIntervalsV3((int, int)[] intervals)
    {
      if (intervals.Count() == 0)
      {
        return 0;
      }

      var intervalsSorted = intervals.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();



      int sumIntervals = 0;
      int i = 0;
      int j = 0;
      while (i < intervalsSorted.Count)
      {
        sumIntervals += intervalsSorted[i].Item2 - intervalsSorted[i].Item1;

        j = i + 1;

        while (j < intervalsSorted.Count
          && intervalsSorted[i].Item1 <= intervalsSorted[j].Item1
          && intervalsSorted[i].Item2 >= intervalsSorted[j].Item2)
        {
          j++;
        }
        if (j < intervalsSorted.Count && (intervalsSorted[i].Item2 > intervalsSorted[j].Item1))
        {
          sumIntervals -= intervalsSorted[i].Item2 - intervalsSorted[j].Item1;
        }

        i = j;
      }

      //var intervalsFiltered = intervalsSorted.Skip(1)
      //  .Where((value, index) => !(value.Item1 >= intervalsSorted[index].Item1 && value.Item2 <= intervalsSorted[index].Item2))
      //  .Prepend(intervalsSorted[0]).ToList();     

      // Subtract overlapping value from Sum
      //sumIntervals -= intervalsFiltered.Skip(1)
      //  .Select((value, index) => (intervalsFiltered[index].Item2 > value.Item1) ? intervalsFiltered[index].Item2 - value.Item1 : 0).Sum();

      return sumIntervals;
    }

    public static int SumIntervalsV2((int, int)[] intervals)
    {
      if (intervals.Count() == 0)
      {
        return 0;
      }

      var intervalsSorted = intervals.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();      
      int sumIntervals = 0;
      int i = 0;
      int j = 0;      
      while (i < intervalsSorted.Count)
      {
        sumIntervals += intervalsSorted[i].Item2 - intervalsSorted[i].Item1;
        
        j = i + 1;
        while (j < intervalsSorted.Count 
          && intervalsSorted[i].Item1 <= intervalsSorted[j].Item1 
          && intervalsSorted[i].Item2 >= intervalsSorted[j].Item2)
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

    public static int SumIntervalsV1((int, int)[] intervals)
    {
      if (intervals.Count() == 0)
      {
        return 0;
      }

      // Sort the intervals
      var intervalsSorted = intervals.OrderBy(t => t.Item1).ThenBy(t => t.Item2).ToList();
      List<(int, int)> intervalsFiltered = new();

      int i = 0;
      int j = 0;
      while (i < intervalsSorted.Count)
      {
        intervalsFiltered.Add(intervalsSorted[i]);

        j = i + 1;
        while (j < intervalsSorted.Count 
          && intervalsSorted[i].Item1 <= intervalsSorted[j].Item1 
          && intervalsSorted[i].Item2 >= intervalsSorted[j].Item2)
        {
          j++;
        }
        i = j;        
      }

      int sumIntervals = intervalsFiltered.Sum(t => t.Item2 - t.Item1);     
      sumIntervals -= intervalsFiltered.Skip(1)
        .Select((value, index) => (intervalsFiltered[index].Item2 > value.Item1) ? intervalsFiltered[index].Item2 - value.Item1 : 0).Sum();

      return sumIntervals;
    }
  }
}
