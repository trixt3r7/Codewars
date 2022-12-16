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
}