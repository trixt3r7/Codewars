using NUnit.Framework;
using Codewars.Fundamentals;

namespace CodeWars.FundamentalsTest
{
  public class Fundamentals
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RemoveEveryOtherBasicTest()
    {
      Assert.That(RemovingElements.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }), Is.EqualTo(new object[] { "Hello", "Hello Again" }));
      Assert.That(RemovingElements.RemoveEveryOther(new object[] { new object[] { 1, 2 } }), Is.EqualTo(new object[] { new object[] { 1, 2 } }));
      Assert.That(RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), Is.EqualTo(new object[] { 1, 3, 5, 7, 9 }));
      Assert.That(RemovingElements.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }), Is.EqualTo(new object[] { new object[] { "Goodbye" } }));
      Assert.That(RemovingElements.RemoveEveryOther(new object[] { }), Is.EqualTo(new object[] { }));
    }

    [Test]
    public void SumMixedArrayBasicTest()
    {
      Assert.That(SumMixedArray.SumMix(new object[] { 9, 3, "7", "3" }), Is.EqualTo(22));
      Assert.That(SumMixedArray.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }), Is.EqualTo(42));
      Assert.That(SumMixedArray.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }), Is.EqualTo(41));
    }

    [Test]
    public void FirstNonConsecutiveTest()
    {
      Assert.That(FindFirstNonConsecutiveNumber.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }), Is.EqualTo(6));
    }

    [Test]
    public void PaddedNumbersTest()
    {
      Assert.That(PaddedNumbers.PadNumbers(5), Is.EqualTo("Value is 00005"));
    }

    [TestFixture]
    public class FeastTests
    {
      [TestCase("great blue heron", "garlic naan")]
      [TestCase("chickadee", "chocolate cake")]
      public void BasicTestsTrue(string beast, string dish)
      {
        Assert.IsTrue(FeastOfManyBeasts.Feast(beast, dish));
      }

      [TestCase("brown bear", "bear claw")]
      public void BasicTestsFalse(string beast, string dish)
      {
        Assert.IsFalse(FeastOfManyBeasts.Feast(beast, dish));
      }
    }
  }
}