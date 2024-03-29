using CodeWars.LevelFive;
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

    [Test]
    public void FindMissingLetterTests()
    {
      Assert.That(MissingLetter.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }), Is.EqualTo('e'));
      Assert.That(MissingLetter.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }), Is.EqualTo('P'));
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
    private SumDigitalRot? num;

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
      Assert.That(num?.DigitalRoot(16), Is.EqualTo(7));
      Assert.That(num.DigitalRoot(195), Is.EqualTo(6));
      Assert.That(num.DigitalRoot(992), Is.EqualTo(2));
      Assert.That(num.DigitalRoot(999999999999), Is.EqualTo(9));
      Assert.That(num.DigitalRoot(167346), Is.EqualTo(9));
      Assert.That(num.DigitalRoot(0), Is.EqualTo(0));
      Assert.That(num.DigitalRoot(10), Is.EqualTo(1));
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
      Assert.That(ConvertToCamelCase.ToCamelCase("the_stealth_warrior"), Is.EqualTo("theStealthWarrior"), "ToCamelCase('the_stealth_warrior') did not return correct value");
      Assert.That(ConvertToCamelCase.ToCamelCase("The-Stealth-Warrior"), Is.EqualTo("TheStealthWarrior"), "ToCamelCase('The-Stealth-Warrior') did not return correct value");
    }
  }

  [TestFixture]
  public class AlternatingSplitTest
  {
    [Test]
    public void EncryptExampleTests()
    {
      Assert.That(AlternatingSplit.Encrypt("This is a test!", 0), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Encrypt("This is a test!", 1), Is.EqualTo("hsi  etTi sats!"));
      Assert.That(AlternatingSplit.Encrypt("This is a test!", 2), Is.EqualTo("s eT ashi tist!"));
      Assert.That(AlternatingSplit.Encrypt("This is a test!", 3), Is.EqualTo(" Tah itse sits!"));
      Assert.That(AlternatingSplit.Encrypt("This is a test!", 4), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Encrypt("This is a test!", -1), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Encrypt("This kata is very interesting!", 1), Is.EqualTo("hskt svr neetn!Ti aai eyitrsig"));
    }

    [Test]
    public void DecryptExampleTests()
    {
      Assert.That(AlternatingSplit.Decrypt("This is a test!", 0), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Decrypt("hsi  etTi sats!", 1), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Decrypt("s eT ashi tist!", 2), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Decrypt(" Tah itse sits!", 3), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Decrypt("This is a test!", 4), Is.EqualTo("This is a test!"));
      Assert.That(AlternatingSplit.Decrypt("This is a test!", -1), Is.EqualTo("This is a test!"));     
      Assert.That(AlternatingSplit.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1), Is.EqualTo("This kata is very interesting!"));
    }

    [Test]
    public void EmptyTests()
    {
      Assert.That(AlternatingSplit.Encrypt("", 0), Is.EqualTo(""));
      Assert.That(AlternatingSplit.Decrypt("", 0), Is.EqualTo(""));
    }

    [Test]
    public void NullTests()
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
      Assert.That(AlternatingSplit.Encrypt(null, 0), Is.EqualTo(null));
      Assert.That(AlternatingSplit.Decrypt(null, 0), Is.EqualTo(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
    }
  }

  [TestFixture]
  public class NumberLookBigTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(1)
                        .Returns(true)
                        .SetDescription("1 is narcissitic");
        yield return new TestCaseData(153)
                        .Returns(true)
                        .SetDescription("153 is narcissitic");
        yield return new TestCaseData(371)
                        .Returns(true)
                        .SetDescription("371 is narcissitic");
        yield return new TestCaseData(929544158)
                        .Returns(false)
                        .SetDescription("929544158 is not narcissitic");
        yield return new TestCaseData(146511208)
                        .Returns(true)
                        .SetDescription("146511208 is narcissitic");
        yield return new TestCaseData(2085408895)
                        .Returns(false)
                        .SetDescription("2085408895 is not narcissitic");
      }
    }

    [Test, TestCaseSource(nameof(testCases))]
    public bool Test(int n) => NumberLookBig.Narcissistic(n);
  }

  [TestFixture]
  public class DigitsPowTests
  {
    [Test]
    public void Test1()
    {
      Assert.That(DigitsPow.digPow(89, 1), Is.EqualTo(1));
    }
    [Test]
    public void Test2()
    {
      Assert.That(DigitsPow.digPow(92, 1), Is.EqualTo(-1));
    }
    [Test]
    public void Test3()
    {
      Assert.That(DigitsPow.digPow(46288, 3), Is.EqualTo(51));
    }
  }


  [TestFixture]
  public class DeleteOccurencesNthTests
  {
    [Test]
    public void DeleteNthTest1()
    {
      var expected = new int[] { 20, 37, 21 };

      var actual = DeleteOccurencesNth.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

      CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void DeleteNthTest2()
    {
      var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

      var actual = DeleteOccurencesNth.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

      CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void DeleteNthTest3()
    {
      var expected = new int[] { 1, 1, 3, 2, 3, 3, 1, 2 };

      var actual = DeleteOccurencesNth.DeleteNth(new int[] { 1, 1, 3, 2, 3, 3, 1, 1, 2, 3 }, 3);

      CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void DeleteNthTest4()
    {
      var expected = new int[] { 2, 1, 2, 2, 1, 1 };

      var actual = DeleteOccurencesNth.DeleteNth(new int[] { 2, 1, 2, 2, 2, 2, 1, 1, 1, 1 }, 3);

      CollectionAssert.AreEqual(expected, actual);
    }
  }
  [TestFixture]
  public class BitCountingTests
  {
    [Test]
    public void CountBits()
    {
      Assert.That(BitCounting.CountBits(0), Is.EqualTo(0));
      Assert.That(BitCounting.CountBits(4), Is.EqualTo(1));
      Assert.That(BitCounting.CountBits(7), Is.EqualTo(3));
      Assert.That(BitCounting.CountBits(9), Is.EqualTo(2));
      Assert.That(BitCounting.CountBits(10), Is.EqualTo(2));
    }
  }

  [TestFixture]
  public class SortOddTests
  {
    [Test]
    public void SortArrayTests()
    {
      Assert.That(SortOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }), Is.EqualTo(new int[] { 1, 3, 2, 8, 5, 4 }));
      Assert.That(SortOdd.SortArray(new int[] { 5, 3, 1, 8, 0 }), Is.EqualTo(new int[] { 1, 3, 5, 8, 0 }));
      Assert.That(SortOdd.SortArray(new int[] { }), Is.EqualTo(new int[] { }));
    }
  }

  [TestFixture]
  public class FindUniqueNumberTest
  {
    [TestCase(new[] { 2, 2, 2, 2, 2, 2, 2, 10, 2, 2, 2, 2 }, ExpectedResult = 10)]
    [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
    [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
    [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers)
    {
      return FindUniqueNumber.GetUnique(numbers);
    }
  }

  [TestFixture]
  public class HighestScoringWordTests
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
        yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
        yield return new TestCaseData("take me to semynak").Returns("semynak");
        yield return new TestCaseData("aa b").Returns("aa");
        yield return new TestCaseData("b aa").Returns("b");
        yield return new TestCaseData("bb d").Returns("bb");
        yield return new TestCaseData("d bb").Returns("d");
        yield return new TestCaseData("aaa b").Returns("aaa");
      }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s) => HighestScoringWord.High(s);
  }
}