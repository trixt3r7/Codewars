namespace CodeWars.LevelFive;

public class MaxSubarraySum
{  
  public static int MaxSequence(int[] arr)
  {
    int maxSubarray = 0;
    int currentSum = 0;

    foreach (var n in arr)
    {
      if (currentSum < 0)
      {
        currentSum = 0;
      }
      currentSum += n;
      maxSubarray = Math.Max(maxSubarray, currentSum);
    }
    
    return (maxSubarray > 0) ? maxSubarray : 0;
  }
  public static int MaxSequenceV2(int[] arr)
  {
    return arr.Aggregate((0, 0), (t, c) => (Math.Max(0, t.Item1 + c), Math.Max(t.Item2, t.Item1 + c))).Item2;
  }
}
