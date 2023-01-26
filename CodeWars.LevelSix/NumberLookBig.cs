namespace CodeWars.LevelSix;

public class NumberLookBig
{
  public static bool Narcissistic(int value)
  {
    char[] digits = value.ToString().ToCharArray();
    return digits.Select(digit => (long)Math.Pow(digit - 48, digits.Count())).Sum() == value ? true : false;
  }

  public static bool NarcissisticV3(int value)
  {
    string digits = value.ToString();
    return digits.Sum(digit => Math.Pow(Convert.ToInt16(digit.ToString()), digits.Length)) == value ? true : false;
  }

  public static bool NarcissisticV1(int value)
  {
    var digits = value.ToString().ToCharArray();
    var length = digits.Length;
    long sum = 0;

    foreach (var digit in digits)
    {
      sum += (long)Math.Pow(digit - 48, length);
    }
    
    return (sum == value) ? true : false;
  }
}
