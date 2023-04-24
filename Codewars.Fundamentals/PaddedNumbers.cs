namespace Codewars.Fundamentals;

public class PaddedNumbers
{
  public static string PadNumbers(int value)
  {
    return $"Value is {value:D5}";
  }
  public static string PadNumbersV2(int value)
  {
    return string.Format("Value is {0:00000}", value);
  }
  public static string PadNumbersV1(int value)
  {
    return $"Value is {value.ToString().PadLeft(5, '0')}";
  }
}
