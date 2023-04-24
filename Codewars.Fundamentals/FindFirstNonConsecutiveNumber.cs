namespace Codewars.Fundamentals;

public class FindFirstNonConsecutiveNumber
{
  public static object FirstNonConsecutive(int[] arr) =>
    arr.Skip(1).SkipWhile((e, id) => e == arr[id] + 1).Cast<int?>().FirstOrDefault()!;

  public static object FirstNonConsecutiveV2(int[] arr) =>
    arr.Cast<int?>().Skip(1).FirstOrDefault(i => i != ++arr[0])!;


  public static object FirstNonConsecutiveV1(int[] arr)
  {
    for (int i = 1; i < arr.Length; i++)
    {
      if (arr[i] - arr[i - 1] != 1)
      {
        return arr[i];
      }
    }
    return null!;
  }
}
