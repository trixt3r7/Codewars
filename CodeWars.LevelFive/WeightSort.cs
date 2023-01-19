using System.Text.RegularExpressions;

namespace CodeWars.LevelFive;

public class WeightSort
{
  public static string orderWeight(string strng)
  {
    return String.Join(" ",
      Regex.Split(strng, @"\s+")
      .Where(s => s != string.Empty)
      .OrderBy(n => n.Sum(c => c - 48))
      .ThenBy(s => s)
      .ToArray());
  }
  public static string orderWeightV1(string strng)
  {
    return String.Join(" ", 
      Regex.Split(strng, @"\s+")
      .Where(s => s != string.Empty)
      .OrderBy(s => s)
      .OrderBy(n => sumDigits(n))
      .ToArray());
  }

  public static int sumDigits(string str)
  {
    return str.ToArray().Select(n => Convert.ToInt32(n)-48).Sum();
  }
}
