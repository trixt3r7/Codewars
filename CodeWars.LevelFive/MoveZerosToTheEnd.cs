namespace CodeWars.LevelFive;

public class MoveZerosToTheEnd
{
  public static int[] MoveZeroes(int[] arr)
  {
    return arr.OrderBy(x => x == 0).ToArray();
  }

  public static int[] MoveZeroesV2(int[] arr)
  {
    return arr.Where(x => x != 0).Concat(arr.Where(y => y == 0)).ToArray();
  }
  public static int[] MoveZeroesV1(int[] arr)
  {
	  List<int> values = new List<int>();
    List<int> zeros = new List<int>();
    for (int i = 0; i < arr.Length; i++)
	{
	  if (arr[i] == 0)
	  {
		zeros.Add(arr[i]);
	  }
	  else
	  {
		values.Add(arr[i]);
	  }
	}

    return values.Concat(zeros).ToArray();
  }
}
