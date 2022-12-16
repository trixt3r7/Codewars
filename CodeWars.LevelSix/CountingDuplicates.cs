using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class CountingDuplicates
{
  public static int DuplicateCount(string str)
  {    
    return str.ToLower().GroupBy(x => x).Where(x => x.Count() > 1).Count();
  }
}
