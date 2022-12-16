using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class CreatePhoneNr
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    var temp = int.Parse(string.Concat(numbers));
    return int.Parse(string.Concat(numbers)).ToString("(000) 000-0000");

  }
  public static string CreatePhoneNumberV2(int[] numbers)
  {
    return string.Join("", numbers).Insert(6, "-").Insert(3, ") ").Insert(0, "(");
  }

  public static string CreatePhoneNumberV1(int[] numbers)
  {
    return $"({string.Join("", numbers.Take(3))}) {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6).Take(4))}";
  }
}