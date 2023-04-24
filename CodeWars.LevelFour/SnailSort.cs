using System.Linq;

namespace CodeWars.LevelFour
{
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            List<int> result = new();
            
            int index = 0;
            while (true)
            {
                var currentList = (index > 0) 
                    ? array.Skip(index).SkipLast(index).Select(x => x.Skip(index).SkipLast(index)).ToList()
                    : array.Select(x => x.AsEnumerable()).ToList();

                if (currentList.Count == 0)
                {
                    break;
                }

                result.AddRange(currentList[0]);
                if(currentList.Count > 1)
                {
                    result.AddRange(currentList.Skip(1).Select(x => x.Last()).SkipLast(1));
                    result.AddRange(currentList.Last().Reverse());
                    result.AddRange(currentList.Skip(1).Select(x => x.First()).SkipLast(1).Reverse());
                }
                index++;
            }
            return result.ToArray();
        }

        public static int[] SnailV1(int[][] array)
        {            
            List<int> result = new();
            
            // Add first row 
            result.AddRange(array[0]);
            
            int index = 0;
            while (index < array.Length - 2)
            {
                if(index > 0)
                {
                    // Add inner first row 
                    result.AddRange(array[index].Skip(index).SkipLast(index));                    
                }

                // Add outer right
                result.AddRange(array.Skip(1 + index).Select(x => x.Last()).SkipLast(1 + index));
               
                if (index == 0)
                {
                    // Add bottom reversed
                    result.AddRange(array[array.Length - 1].Reverse());                    
                }
                else
                {
                    // Add inner bottom
                    result.AddRange(array[array.Length - (1 + index)].Skip(index).SkipLast(index).Reverse());
                }

                // Add outer left reversed
                result.AddRange(array.Skip(1 + index).Select(x => x.First()).SkipLast(1 + index).Reverse());

                index++;

                if(array.Length % 3 == 0)
                {
                    int centerPos = (array.Length + 1) / 2 - 1;
                    result.Add(array[centerPos][centerPos]);
                }
            }

            return result.ToArray();
        }
    }
}
