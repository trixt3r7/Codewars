namespace CodeWars.LevelSix
{
  public class FindUniqueNumber
  {
    public static int GetUnique(IEnumerable<int> numbers)
    {
      return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
    }
    public static int GetUniqueV2(IEnumerable<int> numbers)
    {
      return numbers.GroupBy(i => i).OrderBy(x => x.Count()).FirstOrDefault()!.Key;
    }
    public static int GetUniqueV1(IEnumerable<int> numbers)
    {            
      return (numbers.Take(3).Distinct().Count() == 1) 
        ? numbers.Distinct().FirstOrDefault(x => x != numbers.First()) 
        : numbers.Take(3).GroupBy(i => i).FirstOrDefault(x => x.Count() == 1)!.FirstOrDefault();
    }
  }
}
