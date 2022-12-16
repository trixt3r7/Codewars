using CodeWars.LevelSix;

namespace CodeWars.LevelSixTest
{
  public class LevelSixTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MultiplesThreeFiveTest()
    {
      Assert.That(MultiplesThreeFive.Solution(10), Is.EqualTo(23));
      Assert.That(MultiplesThreeFive.Solution(3), Is.EqualTo(0));
      Assert.That(MultiplesThreeFive.Solution(4), Is.EqualTo(3));
    }

    [Test]
    public void ArrayDiffTest()
    {
      Assert.That(ArrayDifference.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2 }));
      Assert.That(ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2, 2 }));     
      Assert.That(ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }), Is.EqualTo(new int[] { 1 }));     
      Assert.That(ArrayDifference.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }), Is.EqualTo(new int[] { 1, 2, 2 }));
      Assert.That(ArrayDifference.ArrayDiff(new int[] { }, new int[] { 1, 2 }), Is.EqualTo(new int[] { }));
      Assert.That(ArrayDifference.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }), Is.EqualTo(new int[] { 3 }));
    }

    [Test]
    public void IsPangramTests()
    {
      Assert.That(DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog."), Is.EqualTo(true));
    }

    [Test]
    public void PersistenceTest()
    {
      Console.WriteLine("****** Basic Tests");
      Assert.That(PersistentBugger.Persistence(39), Is.EqualTo(3));
      Assert.That(PersistentBugger.Persistence(4), Is.EqualTo(0));
      Assert.That(PersistentBugger.Persistence(25), Is.EqualTo(2));
      Assert.That(PersistentBugger.Persistence(999), Is.EqualTo(4));
    }

    [Test]
    public void find_itTests()
    {
      Assert.That(FindOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }), Is.EqualTo(5));
    }

    [Test]
    public void DuplicateCountTests()
    {
      Assert.That(CountingDuplicates.DuplicateCount("badassed"), Is.EqualTo(3));
      Assert.That(CountingDuplicates.DuplicateCount(""), Is.EqualTo(0));
      Assert.That(CountingDuplicates.DuplicateCount("abcde"), Is.EqualTo(0));
      Assert.That(CountingDuplicates.DuplicateCount("aabbcde"), Is.EqualTo(2));
      Assert.That(CountingDuplicates.DuplicateCount("aabBcde"), Is.EqualTo(2), "should ignore case");
      Assert.That(CountingDuplicates.DuplicateCount("Indivisibility"), Is.EqualTo(1));
      Assert.That(CountingDuplicates.DuplicateCount("Indivisibilities"), Is.EqualTo(2), "characters may not be adjacent");
    }
  }
}