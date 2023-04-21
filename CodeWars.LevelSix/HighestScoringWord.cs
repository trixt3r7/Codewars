namespace CodeWars.LevelSix
{
  public class HighestScoringWord
  {
    public static string High(string s)
    {
      var words = s.Split(" ");
      List<int> scores = s.Split(" ").Select(word => word.Sum(x => x - 96)).ToList();      
      return words[scores.IndexOf(scores.Max())];
    }

    public static string HighV2(string s)
    {
      return s.Split(' ').OrderByDescending(x => x.Sum(z => z - 'a' + 1)).First();
    }

    public static string HighV1(string s)
    {
      var words = s.Split(" ");
      var scores = new List<int>();
      foreach (var item in words)
      {
        scores.Add(item.Sum(x => x - 96));
      }
      var max = scores.Max();
      var index = scores.IndexOf(max);
      return words[index];
    }
  }
}
