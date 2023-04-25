namespace CodeWars.LevelSix;

public class CountingDuplicates
{
  public static int DuplicateCounQueryt(string str)
  {
    return (from c in str.ToLower()
               group c by c into cGroup
               where cGroup.Count() > 1
               select cGroup).Count();
  }
  public static int DuplicateCount(string str)
  {    
    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
  }

  public static int DuplicateCountV2(string str)
  {
    return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
  }
}
