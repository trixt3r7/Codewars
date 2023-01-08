using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelFive;

public class DirectionsReduction
{
  public static string[] dirReducV2(string[] arr)
  {
    Stack<string> stack = new Stack<string>();

    foreach (string direction in arr)
    {
      string? lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

      switch (direction)
      {
        case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
        case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
        case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
        case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
      }
    }
    return stack.Reverse().ToArray();
  }


  public static string[] dirReduc(string[] arr)
  {
    List<string> dir = new List<string>();
    dir.AddRange(arr);
    var i = 0;

    while (i < dir.Count - 1)
    {
      if (dir[i] == "NORTH" && dir[i + 1] == "SOUTH" || 
          dir[i] == "SOUTH" && dir[i + 1] == "NORTH" ||
          dir[i] == "WEST" && dir[i + 1] == "EAST" || 
          dir[i] == "EAST" && dir[i + 1] == "WEST")
      {
        dir.RemoveRange(i, 2);
        i = 0;
      }
      else
      {
        i++;
      }
    }    

    return dir.ToArray();
  }
}
