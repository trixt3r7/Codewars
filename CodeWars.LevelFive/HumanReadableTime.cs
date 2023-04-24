namespace CodeWars.LevelFive;

public class HumanReadableTime
{
  public static string GetReadableTimeV2(int seconds)
  {
    return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
  }

  public static string GetReadableTime(int seconds)
  {
    TimeSpan time = TimeSpan.FromSeconds(seconds);
    return $"{time.Days * 24 + time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
  }
}
