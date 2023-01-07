using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LevelSix;

public class MultiplicationTables
{
  public static int[,] MultiplicationTable(int size)
  {
    int[,] table = new int[size, size];

    var n = Enumerable.Range(0, size).ToList();
    n.ForEach(i => n.ForEach(j => table[i, j] = (i+1) * (j+1)));
    return table;
  }

  public static int[,] MultiplicationTableV1(int size)
  {
    int[,] table = new int[size,size];

    for (int i = 0; i < size; i++)
    {
      for (int j = 0; j < size; j++)
      {
        table[i,j] = (i+1) * (j+1);
      }
    }
    return table;
  }
}
