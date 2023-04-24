namespace CodeWars.LevelSix;

public class FindOddInt
{
  public static int find_it(int[] seq)
  {
    return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
  }
  public static int find_it_v1(int[] seq)
  {
    return seq.GroupBy(x => x).Where(value => value.Count() % 2 != 0).Select(x => x.First()).First();
  }
}
