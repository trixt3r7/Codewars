﻿namespace CodeWars.LevelSix;

public class BitCounting
{
  public static int CountBits(int n)
  {
    return Convert.ToString(n, 2).Count(x => x == '1');
  }
  public static int CountBitsV1(int n)
  {
    return Convert.ToString(n, 2).Where(x => x == '1').Count();
  }
}
