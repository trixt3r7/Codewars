namespace CodeWars.LevelFive;

public class SimplePigLatin
{
  public static string PigItV2(string str)
  {
    return String.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
  }

  public static string PigIt(string str)
  {
    // Split string into an array seperated by <space>
    string[] words = str.Split(' ').ToArray();

    // Move first letter to end of word
    for (int i = 0; i < words.Length; i++)
    {
      // Leave punctuation marks untouched
      if (words[i].Length > 1)
      {
        words[i] = (words[i].Substring(1) + words[i][0] + "ay");
      }      
    }

    // Merge string with spaces between words and output.
    return string.Join(" ", words).Trim();
  }
}
