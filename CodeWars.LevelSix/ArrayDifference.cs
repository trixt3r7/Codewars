namespace CodeWars.LevelSix;

public class ArrayDifference
{
  public static int[] ArrayDiffQuery(int[] a, int[] b)
  {
    return (from num in a 
            where !b.Contains(num)
            select num).ToArray();    
  }

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
