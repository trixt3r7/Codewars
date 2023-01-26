namespace CodeWars.LevelFive;

// Is my friend cheating? - https://www.codewars.com/kata/5547cc7dcad755e480000004/

public class RemovedNumbers
{
  public static List<long[]> removNb(long n)
  {
    // Formula:
    // a * b = sum - a - b
    // Can convert to:
    // a = (sum - b)/(b + 1)
    // b = (sum - a)/(a + 1)

    List<long[]> abList = new List<long[]>();    
    long sum = n * (n + 1) / 2;        
    long a = 0;
    long b = 0;

    for (a = n; a > n/2; a--)
    {
      b = (sum - a) / (a + 1);

      if (b * a == sum - a - b)
      {
        abList.Add(new long[] { b, a });
      }
    }

    return (abList.Count() > 0) ? abList : new List<long[]>();  
  }
}
