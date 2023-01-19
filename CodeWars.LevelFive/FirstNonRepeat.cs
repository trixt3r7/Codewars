namespace CodeWars.LevelFive;

public class FirstNonRepeat
{
  public static string FirstNonRepeatingLetter(string s)
  {
    var test = s.GroupBy(char.ToLower);
    return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(x => x.First().ToString())
            .DefaultIfEmpty("")
            .First();
  }
  public static string FirstNonRepeatingLetterV1(string s)
  {
    string result = "";
    foreach (char c in s)
    {
      int count = s.ToLower().Count(i => i == char.ToLowerInvariant(c));
      if (count == 1)
      {
        result = c.ToString();
        break;
      }
    }

    return result;
  }
}
