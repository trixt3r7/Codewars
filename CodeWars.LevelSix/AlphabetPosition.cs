namespace CodeWars.LevelSix;

public class AlphabetPosition
{
  public static string ReplaceAlphabetPosition(string text)
  {
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(c => c - 96));
  }
}
