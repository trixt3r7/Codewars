namespace CodeWars.LevelFive;

public class RgbToHex
{
  public static string RgbV3(int r, int g, int b)
  {
    int[] rgb = new int[] { r, g, b };

    return string.Join("", rgb
                .Select((value, index) => value > 255 ? 255 : (value < 0 ? 0 : value))
                .Select(i => i.ToString("X2")));
  }

  public static string Rgb(int r, int g, int b)
  {
    int[] rgb = new int[] { r, g, b };

    return string.Join("", rgb
                .Select((value, index) => Math.Max(Math.Min(255, value), 0))
                .Select(i => i.ToString("X2")));
  }

  public static string RgbV2(int r, int g, int b)
  {
    r = Math.Max(Math.Min(255, r), 0);
    g = Math.Max(Math.Min(255, g), 0);
    b = Math.Max(Math.Min(255, b), 0);
    return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }

  public static string RgbV1(int r, int g, int b)
  {
    List<int> rgb = new List<int>();
    List<string> hex = new List<string>();

    rgb.Add(r);
    rgb.Add(g);
    rgb.Add(b);

    foreach (var color in rgb)
    {
      int tmpColor;

      if (color > 255)
      {
        tmpColor = 255;
      }
      else if (color < 0) 
      {
        tmpColor = 0;
      }
      else {
        tmpColor = color;
      }

      hex.Add(tmpColor.ToString("X2"));
    }

    return string.Join("",hex);
  }
}
