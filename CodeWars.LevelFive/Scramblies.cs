namespace CodeWars.LevelFive;

public class Scramblies
{
  public static bool Scramble(string str1, string str2)
  {
    return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
  }

  public static bool ScrambleV2(string str1, string str2)
  {
    return str2.GroupBy(c => c).All(g => str1.Where(c => c == g.Key).Count() >= g.Count());
  }

  public static bool ScrambleV1(string str1, string str2)
  {
    var scramble = str1.ToList();

    foreach (char c in str2)
    {
      if (scramble.Contains(c))
      {
        scramble.Remove(c);
      }        
      else
      {
        return false;
      } 
    }
    return true;
  }
}
