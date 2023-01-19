using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class AlphabetPosition
{
  public static string ReplaceAlphabetPosition(string text)
  {
    return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(c => c - 96));
  }
}
