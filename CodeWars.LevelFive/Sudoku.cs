using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelFive;

public class Sudoku
{  
  public static string DoneOrNot(int[][] board)
  {
    return Enumerable
      .Range(0, 9)
      .SelectMany(i => new[]
      {
          // row check
          board[i].Distinct().Count(), 
          // col check
          board.SelectMany(r => r.Skip(i).Take(1)).Distinct().Count(), 
          // region(square) check
          board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Distinct().Count()
      })
      .All(i => i == 9) ? "Finished!" : "Try again!";
  }

  private static string DoneOrNotV2(int[][] board)
  {
    return Enumerable
      .Range(0, 9)
      .SelectMany(i => new[]
      {
          board[i].Sum(),
          board.Sum(b => b[i]),
          board.Skip(3 * (i / 3)).Take(3).SelectMany(r => r.Skip(3 * (i % 3)).Take(3)).Sum()
      })
      .All(i => i == 45) ? "Finished!" : "Try again!";
  }

  public static string DoneOrNotV1(int[][] board)
  {
    bool colsDistinct = !Enumerable.Range(0,9).Select(i => board.Select(x => x[i]).Distinct().Count() == 9).Contains(false);
    bool rowsDistinct = !board.Select(x => x.Distinct().Count() == 9).Contains(false);
    bool regionDistinct = true;

    // Check regions for duplicate values
    for (int i = 0; i < board.Length; i += 3)
    {
      int[] region = new int[9];
      for (int j = 0; j < board[0].Length; j += 3)
      {
        region[0] = board[j][i];
        region[1] = board[j + 1][i];
        region[2] = board[j + 2][i];
        region[3] = board[j][i + 1];
        region[4] = board[j + 1][i + 1];
        region[5] = board[j + 2][i + 1];
        region[6] = board[j][i + 2];
        region[7] = board[j + 1][i + 2];
        region[8] = board[j + 2][i + 2];
      }

      if (region.Distinct().Count() != 9)
      {
        regionDistinct = false;
      }
    }
      
    return (colsDistinct && rowsDistinct && regionDistinct) ? "Finished!" : "Try again!";
  }
}
