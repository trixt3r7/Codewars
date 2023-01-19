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

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
    public static string CreatePhoneNumberTest(int[] numbers)
    {
      return CreatePhoneNr.CreatePhoneNumber(numbers);
    }

    [Test]
    public void MultiplicationTableTest()
    {
      int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
      Assert.That(MultiplicationTables.MultiplicationTable(3), Is.EqualTo(expected));

      expected = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 4, 6, 8, 10 }, { 3, 6, 9, 12, 15 }, { 4, 8, 12, 16, 20 }, { 5, 10, 15, 20, 25 } };
      Assert.That(MultiplicationTables.MultiplicationTable(5), Is.EqualTo(expected));

    }

    [Test, Description("It should return correct text")]
    public void LikesTest()
    {
      Assert.That(WhoLikesIt.Likes(new string[0]), Is.EqualTo("no one likes this"));
      Assert.That(WhoLikesIt.Likes(new string[] { "Peter" }), Is.EqualTo("Peter likes this"));
      Assert.That(WhoLikesIt.Likes(new string[] { "Jacob", "Alex" }), Is.EqualTo("Jacob and Alex like this"));
      Assert.That(WhoLikesIt.Likes(new string[] { "Max", "John", "Mark" }), Is.EqualTo("Max, John and Mark like this"));
      Assert.That(WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }), Is.EqualTo("Alex, Jacob and 2 others like this"));
    }

    [Test]
    public void SplitStringTests()
    {
      Assert.That(SplitStrings.SplitString("abc"), Is.EqualTo(new string[] { "ab", "c_" }));
      Assert.That(SplitStrings.SplitString("abcdef"), Is.EqualTo(new string[] { "ab", "cd", "ef" }));
    }
  }

  [TestFixture]
  public class SpinWordsTests
  {
    [Test]
    public static void SpinWordsTest1()
    {
      Assert.That(WordsReversed.SpinWords("Welcome"), Is.EqualTo("emocleW"));
    }

    [Test]
    public static void SpinWordsTest2()
    {
      Assert.That(WordsReversed.SpinWords("Hey fellow warriors"), Is.EqualTo("Hey wollef sroirraw"));
    }

    [Test]
    public static void SpinWordsTest3()
    {
      Assert.That(WordsReversed.SpinWords("This is a test"), Is.EqualTo("This is a test"));
    }

    [Test]
    public static void SpinWordsTest4()
    {
      Assert.That(WordsReversed.SpinWords("This is another test"), Is.EqualTo("This is rehtona test"));
    }

    [Test]
    public static void SpinWordsTest5()
    {
      Assert.That(WordsReversed.SpinWords("You are almost to the last test"), Is.EqualTo("You are tsomla to the last test"));
    }

    [Test]
    public static void SpinWordsTest6()
    {
      Assert.That(WordsReversed.SpinWords("Just kidding there is still one more"), Is.EqualTo("Just gniddik ereht is llits one more"));
    }
  }
  [TestFixture]
  public class SumDigitalRotTest
  {
    private SumDigitalRot num;

    [SetUp]
    public void SetUp()
    {
      num = new SumDigitalRot();
    }

    [TearDown]
    public void TearDown()
    {
      num = null;
    }

    [Test]
    public void DigitalRootTests()
    {
      Assert.That(num.DigitalRoot(16), Is.EqualTo(7));
      Assert.That(num.DigitalRoot(195), Is.EqualTo(6));
      Assert.That(num.DigitalRoot(992), Is.EqualTo(2));
      Assert.That(num.DigitalRoot(999999999999), Is.EqualTo(9));
      Assert.That(num.DigitalRoot(167346), Is.EqualTo(9));
      Assert.That(num.DigitalRoot(0), Is.EqualTo(0));
      Assert.That(num.DigitalRoot(10), Is.EqualTo(1));
    }
  }

}