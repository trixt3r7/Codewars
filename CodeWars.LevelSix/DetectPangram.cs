using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class DetectPangram
{
  public static bool IsPangram(string str)
  {
    return str.ToLower().Where(Char.IsLetter).Distinct().Count() == 26;
  }

  public static bool IsPangramV1(string str)
  {
    HashSet<char> alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToHashSet<char>();
    char[] strAlphabet = str.ToLower().Distinct().Where(x => alphabet.Contains(x)).OrderBy(c => c).ToArray();
    
    return alphabet.SequenceEqual(strAlphabet);
  }
}
