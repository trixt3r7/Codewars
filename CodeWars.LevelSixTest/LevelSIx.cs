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
  public class DuplicateEncoderTests
  {
    [Test]
    public void DuplicateEncodeTests()
    {
      //Assert.That(DuplicateEncoder.DuplicateEncode("din"), Is.EqualTo("((("));
      Assert.That(DuplicateEncoder.DuplicateEncode("recede"), Is.EqualTo("()()()"));
      Assert.That(DuplicateEncoder.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
      Assert.That(DuplicateEncoder.DuplicateEncode("(( @"), Is.EqualTo("))(("));
    }
  }

  [TestFixture]
  public class UniqueOrderedTest
  {
    [Test]
    public void UniqueInOrderTest1()
    {
      Assert.That(UniqueOrdered.UniqueInOrder(""), Is.EqualTo(""));
    }
    [Test]
    public void UniqueInOrderTest2()
    {
      Assert.That(UniqueOrdered.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
    [Test]
    public void UniqueInOrderTest3()
    {
      Assert.That(UniqueOrdered.UniqueInOrder("ABBCcAD"), Is.EqualTo("ABCcAD"));
    }
    [Test]
    public void UniqueInOrderTest4()
    {
      Assert.That(UniqueOrdered.UniqueInOrder(new int[] { 1, 2, 2, 3, 3 }), Is.EqualTo(new int[] { 1, 2, 3 }));
    }
  }

  [TestFixture]
  public class FindOutlierTests
  {
    [Test]
    public static void FindTest1()
    {
      int[] exampleTest1 = { 2, 6, 8, -10, 3 };
      Assert.IsTrue(3 == FindOutlier.Find(exampleTest1));
    }

    [Test]
    public static void FindTest2()
    {
      int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
      Assert.IsTrue(206847684 == FindOutlier.Find(exampleTest2));
    }

    [Test]
    public static void FindTest3()
    {
      int[] exampleTest3 = { int.MaxValue, 0, 1 };
      Assert.IsTrue(0 == FindOutlier.Find(exampleTest3));
    }
  }

  [TestFixture]
  public class AlphabetPositionTest
  {
    [Test]
    public void ReplaceAlphabetPositionTest()
    {
      Assert.That(AlphabetPosition.ReplaceAlphabetPosition("The sunset sets at twelve o' clock."),
        Is.EqualTo("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"));
      Assert.That(AlphabetPosition.ReplaceAlphabetPosition("The narwhal bacons at midnight."),
        Is.EqualTo("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20"));
    }
  }

  [TestFixture]
  public class ConvertToCamelCaseTest
  {
    [Test]
    public void ToCamelCaseTests()
    {
      Assert.That(ConvertToCamelCase.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
      Assert.That(ConvertToCamelCase.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
  }
}