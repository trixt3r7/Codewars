using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Fundamentals;

public class FeastOfManyBeasts
{
  public static bool Feast(string beast, string dish)
  {
	return beast[0] == dish[0] && beast[^1] == dish[^1];
  }
}
