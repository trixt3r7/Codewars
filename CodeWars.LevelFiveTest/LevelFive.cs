using CodeWars.LevelFive;

namespace CodeWars.LevelFiveTest
{
  public class LevelFiveTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MoveZeroesTest()
    {
      Assert.That(MoveZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }));
      Assert.That(MoveZerosToTheEnd.MoveZeroes(new int[] { 1, 0, 0, 0, 5, 2, 0, 0, 1, 1 }), Is.EqualTo(new int[] { 1, 5, 2, 1, 1, 0, 0, 0, 0, 0 }));
    }

    [Test]
    public void PigItTests()
    {
      Assert.That(SimplePigLatin.PigIt("Pig latin is cool"), Is.EqualTo("igPay atinlay siay oolcay"));
      Assert.That(SimplePigLatin.PigIt("This is my string"), Is.EqualTo("hisTay siay ymay tringsay"));
    }

    [Test]
    public void HumanReadableTest()
    {
      Assert.That(HumanReadableTime.GetReadableTime(0), Is.EqualTo("00:00:00"));
      Assert.That(HumanReadableTime.GetReadableTime(5), Is.EqualTo("00:00:05"));
      Assert.That(HumanReadableTime.GetReadableTime(60), Is.EqualTo("00:01:00"));
      Assert.That(HumanReadableTime.GetReadableTime(86399), Is.EqualTo("23:59:59"));
      Assert.That(HumanReadableTime.GetReadableTime(359999), Is.EqualTo("99:59:59"));
    }
  }

  [TestFixture]
  public class RgbToHexConversionTests
  {
    [Test]
    public void RgbToHexTests()
    {
      Assert.That(RgbToHex.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
      Assert.That(RgbToHex.Rgb(255, 255, 300), Is.EqualTo("FFFFFF"));
      Assert.That(RgbToHex.Rgb(0, 0, 0), Is.EqualTo("000000"));
      Assert.That(RgbToHex.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
      Assert.That(RgbToHex.Rgb(148, -20, 211), Is.EqualTo("9400D3"), "Handle negative numbers.");
      Assert.That(RgbToHex.Rgb(144, 195, 212), Is.EqualTo("90C3D4"));
      Assert.That(RgbToHex.Rgb(212, 53, 12), Is.EqualTo("D4350C"), "Consider single hex digit numbers.");
    }
  }

  [TestFixture]
  public class DirReductionTests
  {

    [Test]
    public void Test1()
    {
      string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
      string[] b = new string[] { "WEST" };
      Assert.That(DirectionsReduction.dirReduc(a), Is.EqualTo(b));
    }
    [Test]
    public void Test2()
    {
      string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
      string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
      Assert.That(DirectionsReduction.dirReduc(a), Is.EqualTo(b));
    }
  }
}