namespace CodeWars.LevelSix;

public class DigitsPow
{
  public static long digPowV3(int n, int p)
  {
    var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
    return sum % n == 0 ? sum / n : -1;
  }
  public static long digPow(int n, int p)
  {   
    long sum = n.ToString().ToCharArray()
                .Select(digit => (long)Math.Pow(digit - 48, p++))
                .Sum();
    return sum % n == 0 ? sum / n : -1;
  }

  public static long digPowV1(int n, int p)
  {
    char[] digits = n.ToString().ToCharArray();
    long sum = 0;
    for (int i = 0; i < digits.Length; i++)
    {
      sum += (long)Math.Pow(digits[i] - 48, p+i);
    }
    long multiplier = sum / n;

    return multiplier * n == sum ? multiplier : -1;
  }
}
