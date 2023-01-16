using System.Numerics;

namespace CodeWars.LevelFour;

public  class AddingBigNumbers
{
  public static string AddV3(string a, string b)
  {
    return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
  }

  public static string Add(string a, string b)
  {
    var aa = a.PadLeft(Math.Max(a.Length, b.Length), '0').Select(x => x - 48).ToArray();
    var bb = b.PadLeft(Math.Max(a.Length, b.Length), '0').Select(x => x - 48).ToArray();
    var rs = "";
    var add = 0;
    for (int i = aa.Length - 1; i > 0; i--)
    {
      rs = (aa[i] + bb[i] + add) % 10 + rs;
      add = (aa[i] + bb[i] + add) / 10;
    }
    var temp = (aa[0] + bb[0] + add) + rs;
    return (aa[0] + bb[0] + add) + rs;
  }
  public static string AddV1(string a, string b)
  {
    // Make string a & b have equal length
    if (a.Length != b.Length)
    {
      if (a.Length < b.Length)
        a = a.PadLeft(b.Length, '0');
      else
        b = b.PadLeft(a.Length, '0');
    }

    Stack<string> sumStack = new Stack<string>();

    int addDigit = 0;
    for (int i = a.Length - 1; i >= 0; i--)
    {
      int sumDigits = Convert.ToInt16(a[i].ToString()) + Convert.ToInt16(b[i].ToString()) + addDigit;
      if (sumDigits > 9)
      {
        sumStack.Push((sumDigits - 10).ToString());
        addDigit = 1;
      }
      else
      {
        sumStack.Push((sumDigits).ToString());
        addDigit = 0;
      }
    }
    if (addDigit == 1)
    {
      sumStack.Push("1");
    }

    return string.Join("", sumStack);
  }
}
