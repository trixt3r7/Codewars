namespace CodeWars.LevelSix;

public class WordsReversed
{
  public static string SpinWords(string sentence)
  {
    return String.Join(" ", sentence.Split(' ')
                  .Select((value, index) => (value.Length > 4)
                  ? new string(value.Reverse().ToArray()) : value));
  }
  public static string SpinWordsV2(string sentence)
  {
    string[] words = sentence.Split(' ').ToArray();
    return String.Join(" ", words
                  .Select((value, index) => (value.Length > 4)
                  ? new string(value.Reverse().ToArray()) : value));
  }
  public static string SpinWordsV1(string sentence)
  {
    string[] words = sentence.Split(' ').ToArray();
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Length >= 5)
      {
        words[i] = new string(words[i].Reverse().ToArray());
      }
    }

    return string.Join(" ", words);
  }
}
