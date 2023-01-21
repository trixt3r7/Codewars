using System.Text.RegularExpressions;

namespace CodeWars.LevelSix;

public class ConvertToCamelCase
{
  public static string ToCamelCase(string str)
  {
    return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
  }

  public static string ToCamelCaseV2(string str)
  {
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
  }
  public static string ToCamelCaseV1(string str)
  {
    var result = "";
    bool upper = false;

    foreach (char c in str)
    {
      if (c == '_' || c == '-')
      {
        upper = true;
      }
      else if (upper)
      {
        result += char.ToUpper(c);
        upper = false;
      }
      else
      {
        result += c;
      }
    }

    return result;
  }
}
