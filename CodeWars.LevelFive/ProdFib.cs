namespace CodeWars.LevelFive;

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
// F(n) * F(n+1) = prod.

// Having the product that need comparing and split in two fibonacci sequences.
// It will always be a neighbour pair of Fibonacci sequences e.g. 3*5 or 21*34

// Get fib number and store as first value
// Get next fib number and store as second value
// multiply values and compare to "prod"
// & if equal or higher stop the loop and give the result

// I'll assume we do a regular fibonacci sequence but within compare to the result at each step


public class ProdFib
{
  public static ulong[] ProductFib(ulong prod)
  {    
    List<ulong> FibSeq = new List<ulong>() { 0, 1 };
    int i = 2;
    ulong calcProd = 0;

    while (prod > calcProd)
    {
      FibSeq.Add(FibSeq[i - 2] + FibSeq[i - 1]);
      calcProd = FibSeq[i - 1] * FibSeq[i];
      i++;
    }

    return new ulong[] { FibSeq[i - 2], FibSeq[i - 1], (ulong)((prod == calcProd) ? 1 : 0) };
  }
}
