using System.Net.Sockets;
using System.Numerics;

namespace CodeWars.LevelFive;

// https://www.codewars.com/kata/5547cc7dcad755e480000004/train/csharp

public class RemovedNumbers
{
  public static List<long[]> removNb(long n)
  {
    //long sequenceSum = Enumerable.Range(1, Convert.ToInt32(n)).Sum();
    long sequenceSum = 0;
    for (int i = 1; i <= n; i++)
    {
      sequenceSum += i;
    }


    List<long[]> values = new List<long[]>();


    long a = n / 2;
    long b = n;

    long abMultiplication = a*b;
    long subtractedSum = sequenceSum - a - b;

    // where    
    var formula = sequenceSum - a - b - (a * b); // == 0    

    //while (sequenceSum - a - b - (a * b) != 0)
    //{
    //  //a = 550320;
    //  //b = 908566;
    //  abMultiplication = a * b;
    //  subtractedSum = sequenceSum - a - b;

    //  formula = subtractedSum - abMultiplication;

    //  if (formula > n/3)
    //  {
    //    a += (long)Math.Sqrt(a);
    //  }
    //  else if (formula < -n/3)
    //  {
    //    b -= (long)Math.Sqrt(b);
    //  }

    //  if (formula > n)
    //  {
    //    a += 1;
    //  }
    //  else if (formula < -n)
    //  {
    //    b -= 1;
    //  }
    //}

    for (long i = n/2; i < n; i++)
    {
      for (long j = n/2; i < n - 1; j++)
      {
        abMultiplication = i * j;
        subtractedSum = sequenceSum - (i + j);

        // Not enought break for loop for current iteration
        if (formula > n)
        {
          break;
        }

        abMultiplication = i * j;
        subtractedSum = sequenceSum - i - j;

        formula = subtractedSum - abMultiplication;

        if (formula > n)
        {
          j = j - (long)(j * 1.001);
          // modify
          //j = j - ((subtractedSum - abMultiplication) / (j + j));
        }

        // They are equal & end
        if (formula == 0)
        {
          values.Add(new long[] { i, j });
        }




      }


    }
    return new List<long[]> { };
  }
}
