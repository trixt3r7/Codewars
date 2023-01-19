using System.Linq;

namespace CodeWars.LevelSix;

public class DuplicateEncoder
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToLower();
    return string.Concat(word.Select(x => word.Count(w => w == x) > 1 ? ')' : '('));
  }

  public static string DuplicateEncodeV2(string word)
  {
    var duplicates = word.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();
    return string.Concat(word.Select(x => duplicates.Contains(char.ToLowerInvariant(x)) == true ? ")" : "("));
  }

  public static string DuplicateEncodeV1(string word)
  {
    string newString = "";
    var duplicates = word.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();

    foreach (var c in word)
    {
      newString += (duplicates.Contains(char.ToLowerInvariant(c))) ? ")" : "(";     
    }
    return newString;
  }
}
