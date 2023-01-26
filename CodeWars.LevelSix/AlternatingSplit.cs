namespace CodeWars.LevelSix;

// Simple Encryption #1 - Alternating Split - https://www.codewars.com/kata/57814d79a56c88e3e0000786

public class AlternatingSplit
{
  public static string Encrypt(string text, int n)
  {
    List<char> even = new List<char>();
    List<char> odd = new List<char>();

    while(n > 0 && !string.IsNullOrEmpty(text))
    {
      for (int i = 0; i < text.Length; i++)
      {
        if (i % 2 == 0)
        {
          even.Add(text[i]);
        }
        else
        {
          odd.Add(text[i]);
        }
      }
      text = string.Join("", odd.Concat(even));
      n--;
      even.Clear();
      odd.Clear();
    }    

    return text;
  }

  public static string Decrypt(string encryptedText, int n)
  {
    List<char> result = new List<char>();

    while (n > 0 && !string.IsNullOrEmpty(encryptedText))
    {
      var leftText = encryptedText.Substring(encryptedText.Length / 2);
      var rightText = encryptedText.Substring(0, encryptedText.Length / 2);

      for (int i = 0; i < leftText.Length; i++)
      {
        result.Add(leftText[i]);
        if (i < rightText.Length)
          result.Add(rightText[i]);
      }

      encryptedText = string.Join("", result);
      n--;
      result.Clear();
    }

    return encryptedText;
  }
}
