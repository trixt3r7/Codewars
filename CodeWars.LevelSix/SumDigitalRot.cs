namespace CodeWars.LevelSix;

public class SumDigitalRot
{
  public int DigitalRoot(long n)
  {
    return (int)(1 + (n - 1) % 9);
    // 1 + (16 - 1) % 9 => 1 + (15 % 9) => 1 + 6
    // 1 + (456 - 1) % 9 => 1 + (455 % 9) => 1 + 5
  }
  public int DigitalRootV1(long n)
  {
    while (n > 9)
    {
      n = n.ToString().Select(digit => int.Parse(digit.ToString())).Sum();
    }
    return (int)n;
  }
}