namespace CodeWars.LevelSix;

public class FindOutlier
{  
  public static int Find(int[] integers)
  {
    var evenNumbers = integers.Where(integer => integer % 2 == 0);
    var oddNumbers = integers.Where(integer => integer % 2 == 1);
    return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
  }
  public static int FindV2(int[] integers)
  {
    return integers.Count(a => a % 2 == 1) > 1
      ? integers.Single(a => a % 2 == 0)
      : integers.Single(a => a % 2 == 1);
  }

  public static int FindV1(int[] integers)
  {
    int checkOddEven = integers.Select(x => x % 2).Sum();

    return (checkOddEven == 1) ? integers.Single(n => n % 2 != 0)
      : integers.Single(n => n % 2 == 0);
  }
}
