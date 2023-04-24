namespace CodeWars.LevelSix;

public class CountingDuplicates
{   
  public static int DuplicateCount(string str)
  {    
    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
  }

  public static int DuplicateCountV2(string str)
  {
    return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
  }
}
