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

  [TestFixture]
  public class WeightSortTests
  {

    [Test]
    public void orderWeightTest()
    {
      Console.WriteLine("****** Basic Tests");
      Assert.That(WeightSort.orderWeight("113 143 444  99   231 "), Is.EqualTo("113 231 143 444 99"));
      Assert.That(WeightSort.orderWeight("103 123 4444 99 2000"), Is.EqualTo("2000 103 123 4444 99"));
      Assert.That(WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"), Is.EqualTo("11 11 2000 10003 22 123 1234000 44444444 9999"));
    }
  }
}