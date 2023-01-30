namespace CodeWars.LevelSix;

public class DeleteOccurencesNth
{
  public static int[] DeleteNth(int[] arr, int x)
  {
    var result = new List<int>();
    foreach (var num in arr)
    {
      if (result.Count(i => i == num) < x)
      {
        result.Add(num);
      }
    }
    return result.ToArray();
  }

  public static int[] DeleteNthV1(int[] arr, int x)
  {
    Dictionary<int, int> numCounter = new Dictionary<int, int>();
    List<int> result = new List<int>();
    
    foreach (var num in arr)
    {      
      if (numCounter.ContainsKey(num))
      {
        numCounter[num]++;
      }
      else
      {
        numCounter.TryAdd(num, 1);
      }
      if (numCounter[num] <= x)
      {
        result.Add(num);
      }      
    }
    
    return result.ToArray();
  }
}
