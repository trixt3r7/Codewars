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
  public class Rot13Test
  {
    [Test]
    public void Test1()
    {
      Assert.That(Rot13Cipher.Rot13("test"), Is.EqualTo("grfg"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Rot13Cipher.Rot13("test")));
    }

    [Test]
    public void Test2()
    {
      Assert.That(Rot13Cipher.Rot13("Test"), Is.EqualTo("Grfg"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13Cipher.Rot13("Test")));
    }
    [Test]
    public void Test3()
    {
      Assert.That(Rot13Cipher.Rot13("10+2 is twelve."), Is.EqualTo("10+2 vf gjryir."), String.Format("Input: Test, Expected Output: 10+2 vf gjryir., Actual Output: {0}", Rot13Cipher.Rot13("10+2 is twelve.")));
    }
    [Test]
    public void Test4()
    {
      Assert.That(Rot13Cipher.Rot13("Codewars"), Is.EqualTo("Pbqrjnef"), String.Format("Input: Test, Expected Output: Pbqrjnef, Actual Output: {0}", Rot13Cipher.Rot13("Codewars")));
    }
  }

  [TestFixture]
  public class FirstNonRepeatTest
  {
    [Test]
    public void FirstNonRepeatingLetterTests()
    {
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("a"), Is.EqualTo("a"));
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("stress"), Is.EqualTo("t"));
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("moonmen"), Is.EqualTo("e"));
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("Reset"), Is.EqualTo("R"));

      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("aabb"), Is.EqualTo(""));
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter(""), Is.EqualTo(""));
      Assert.That(FirstNonRepeat.FirstNonRepeatingLetter("}}][["), Is.EqualTo("]"));
    }
  }
  [TestFixture]
  public class ParenthesesTest
  {
    [Test]
    public void ValidParenthesesTest1()
    {
      Assert.That(Parentheses.ValidParentheses("()"), Is.EqualTo(true));
    }

    [Test]
    public void ValidParenthesesTest2()
    {
      Assert.That(Parentheses.ValidParentheses(")(((("), Is.EqualTo(false));
    }

    [Test]
    public void ValidParenthesesTest3()
    {
      Assert.That(Parentheses.ValidParentheses("(())((()())())"), Is.EqualTo(true));
    }
    [Test]
    public void ValidParenthesesTest4()
    {
      Assert.That(Parentheses.ValidParentheses("("), Is.EqualTo(false));
    }
    [Test]
    public void ValidParenthesesTest5()
    {
      Assert.That(Parentheses.ValidParentheses("hi(hi))("), Is.EqualTo(false));
    }
    [Test]
    public void ValidParenthesesTest6()
    {
      Assert.That(Parentheses.ValidParentheses("hi(hi)"), Is.EqualTo(true));
    }
  }
  [TestFixture]
  public class MaxSubarraySumTest
  {
    [Test]
    public void MaxSequenceTest1()
    {
      Assert.That(MaxSubarraySum.MaxSequence(new int[0]), Is.EqualTo(0));
    }
    [Test]
    public void MaxSequenceTest2()
    {
      Assert.That(MaxSubarraySum.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), Is.EqualTo(6));
    }
    [Test]
    public void MaxSequenceTest3()
    {
      Assert.That(MaxSubarraySum.MaxSequence(new int[] { -2, -3 }), Is.EqualTo(0));
    }
  }

  [TestFixture]
  public class GreedIsGoodTest
  {
    [Test]
    public static void ShouldBeWorthless()
    {
      Assert.That(GreedIsGood.Score(new int[] { 2, 3, 4, 6, 2 }), Is.EqualTo(0), "Should be 0 :-(");
    }

    [Test]
    public static void ShouldValueTriplets()
    {
      Assert.That(GreedIsGood.Score(new int[] { 4, 4, 4, 3, 3 }), Is.EqualTo(400), "Should be 400");
    }

    [Test]
    public static void ShouldValueMixedSets()
    {
      Assert.That(GreedIsGood.Score(new int[] { 2, 4, 4, 5, 4 }), Is.EqualTo(450), "Should be 450");
    }
    [Test]
    public static void OnesAndFives()
    {
      Assert.That(GreedIsGood.Score(new int[] { 1, 1, 1, 1, 5 }), Is.EqualTo(1150), "Should be 1150");
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

  [TestFixture]
  public class ProdFibTests
  {

    [Test]
    public void Test0()
    {
      ulong[] r = new ulong[] { 3, 5, 1 };
      Assert.That(ProdFib.ProductFib(15), Is.EqualTo(r));
    }
    [Test]
    public void Test1()
    {
      ulong[] r = new ulong[] { 55, 89, 1 };
      Assert.That(ProdFib.ProductFib(4895), Is.EqualTo(r));
    }
    [Test]
    public void Test2()
    {
      ulong[] r = new ulong[] { 21, 34, 1 };
      Assert.That(ProdFib.ProductFib(714), Is.EqualTo(r));
    }
    [Test]
    public void Test3()
    {
      ulong[] r = new ulong[] { 34, 55, 0 };
      Assert.That(ProdFib.ProductFib(800), Is.EqualTo(r));
    }
  }

  [TestFixture]
  public static class ScrambliesTests
  {

    private static void testing(bool actual, bool expected)
    {
      Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void ScrambleTest1()
    {
      testing(Scramblies.Scramble("rkqodlw", "woorld"), false);
      testing(Scramblies.Scramble("rkqodlw", "world"), true);
      testing(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
      testing(Scramblies.Scramble("katas", "steak"), false);
      testing(Scramblies.Scramble("scriptjavx", "javascript"), false);
      testing(Scramblies.Scramble("scriptingjava", "javascript"), true);
      testing(Scramblies.Scramble("scriptsjava", "javascripts"), true);
      testing(Scramblies.Scramble("javscripts", "javascript"), false);
      testing(Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
      testing(Scramblies.Scramble("commas", "commas"), true);
      testing(Scramblies.Scramble("sammoc", "commas"), true);
    }
  }

  // TODO: Replace examples and use TDD development by writing your own tests

  [TestFixture]
  public class PagnationTest
  {
    private readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
    private PagnationHelper<int> helper;

    [SetUp]
    public void SetUp()
    {
      helper = new PagnationHelper<int>(collection, 10);
    }

    [Test]
    [TestCase(-1, ExpectedResult = -1)]
    [TestCase(0, ExpectedResult = 10)]
    [TestCase(1, ExpectedResult = 10)]
    [TestCase(2, ExpectedResult = 4)]
    [TestCase(3, ExpectedResult = -1)]
    public int PageItemCountTest(int pageIndex)
    {
      return helper.PageItemCount(pageIndex);
    }

    [Test]
    [TestCase(-1, ExpectedResult = -1)]
    [TestCase(0, ExpectedResult = 0)]
    [TestCase(1, ExpectedResult = 0)]
    [TestCase(9, ExpectedResult = 0)]
    [TestCase(10, ExpectedResult = 1)]
    [TestCase(11, ExpectedResult = 1)]
    [TestCase(19, ExpectedResult = 1)]
    [TestCase(20, ExpectedResult = 2)]
    [TestCase(21, ExpectedResult = 2)]
    [TestCase(22, ExpectedResult = 2)]
    [TestCase(23, ExpectedResult = 2)]
    [TestCase(24, ExpectedResult = -1)]
    public int PageIndexTest(int itemIndex)
    {
      return helper.PageIndex(itemIndex);
    }

    [Test]
    public void ItemCountTest()
    {
      Assert.That(helper.ItemCount, Is.EqualTo(24));
    }

    [Test]
    public void PageCountTest()
    {
      Assert.That(helper.PageCount, Is.EqualTo(3));
    }
    
    [Test]
    public void EmptyCollectionPageIndexTest()
    {
      helper = new PagnationHelper<int>(new List<int>(), 10);
      Assert.That(helper.PageIndex(0), Is.EqualTo(-1));
    }
  }

  [TestFixture]
  public class SudokuTests
  {
    private static object[] testCases = new object[]
    {
      new object[]
      {
        "Finished!",
        new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        },
      },
      new object[]
      {
        "Try again!",
        new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
          new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        },
      },
    };

    [Test, TestCaseSource("testCases")]
    public void DoneOrNotTest(string expected, int[][] board) => Assert.That(Sudoku.DoneOrNot(board), Is.EqualTo(expected));
  }

  [TestFixture]
  public class RemovedNumbersTests
  {
    [Test]
    public void RandomTest()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 178, 258 },
        new long[] { 258, 178 }
    };
      Assert.That(RemovedNumbers.removNb(304), Is.EqualTo(r));
    }

    [Test]
    public void Test1()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 15, 21 },
        new long[] { 21, 15 }      
    };
      Assert.That(RemovedNumbers.removNb(26), Is.EqualTo(r));
    }

    [Test]
    public void Test10()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 550320, 908566 },
        new long[] { 559756, 893250 },
        new long[] { 893250, 559756 },
        new long[] { 908566, 550320 }               
    };
      Assert.That(RemovedNumbers.removNb(1000003), Is.EqualTo(r));
    }

    [Test]
    public void Test11()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 677076, 738480 },
        new long[] { 738480, 677076 }
    };
      Assert.That(RemovedNumbers.removNb(1000008), Is.EqualTo(r));
    }

    [Test]
    public void Test2()
    {
      Assert.That(RemovedNumbers.removNb(100), Is.EqualTo(new List<long[]> { }));
    }

    [Test]
    public void Test3()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 55, 91 },
        new long[] { 91, 55 }
    };
      Assert.That(RemovedNumbers.removNb(101), Is.EqualTo(r));
    }

    [Test]
    public void Test4()
    {
      List<long[]> r = new List<long[]> {
        new long[] { 70, 73 },
        new long[] { 73, 70 }
    };
      Assert.That(RemovedNumbers.removNb(102), Is.EqualTo(r));
    }


    // 304 - RandomTest <178,258>
    // 26 - Test1 <15,21>
    // 1000003 - Test10 <550320,908566>
    // 1000008 - Test11 <677076,738480>
    // 101 - Test3 <55,91>
    // 102 - Test4 <70,73>
    // 110 - Test5 <70,85>
    // 1006 - Test6 <546,925>
    // 103 - Test7
    // 446 - Test8 <252, 393>
    // 846 - Test9 <498, 717>

  }
}