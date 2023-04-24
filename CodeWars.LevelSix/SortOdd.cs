namespace CodeWars.LevelSix;

public class SortOdd
{
  public static int[] SortArray(int[] array)
  {
    var oddArray = array.Where(n => n % 2 == 1).OrderBy(n => n).ToArray();
	int counter = 0;
	return array.Select(n => n % 2 == 1 ? oddArray[counter++] : n).ToArray();
  }
}
