namespace CodeWars.LevelSix;

public class MultiplesThreeFive
{
  public static int Solution(int value)
  {
    if (value < 4)
      return 0;

    return Enumerable.Range(0, value)
                    .Where(i => (i % 3 == 0 || i % 5 == 0))
                    .ToList()
                    .Sum();
  }

  public static int SolutionV1(int value)
  {
    if (value < 0)
      return 0;

    int sum = 0;

    for (int i = 0; i < value; i++)
    {
      if (i % 3 == 0 || i % 5 == 0)
      {
        sum += i;
      }
    }

    return sum;
  }
}
