namespace CodeWars.LevelFive;

// https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
// A-Z => 65-90
// a-z => 97-122

public class Rot13Cipher
{
  public static string Rot13(string message)
  {
    return String.Join("", message
                  .Select(x => char.IsLetter(x) 
                    ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) 
                    ? (char)(x + 13) : (char)(x - 13) : x));
  }
  public static string Rot13V2(string message)
  {
    string result = "";
    foreach (var s in message)
    {
      if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
        result += Convert.ToChar((s + 13)).ToString();
      else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
        result += Convert.ToChar((s - 13)).ToString();
      else result += s;
    }
    return result;
  }

  public static string Rot13V1(string message)
  {
    List<char> rotMessage = new List<char>();
    rotMessage.AddRange(message);
    int rotShift = 13;

    for (int i = 0; i < rotMessage.Count; i++)
    {
      int shift = (int)rotMessage[i];
      char currentChar = rotMessage[i];

      if (Char.IsLetter(currentChar))
      {
        shift += rotShift;

        if (Char.IsUpper(currentChar) && shift > 90 || shift > 122)
        {
          shift -= 26;
        }
      }
      rotMessage[i] = (char)shift;
    }
    return string.Join("", rotMessage);
  }
}
