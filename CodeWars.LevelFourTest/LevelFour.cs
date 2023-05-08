using CodeWars.LevelFour;
using NUnit.Framework.Constraints;
using Interval = System.ValueTuple<int, int>; // For SumOfIntervalTest

namespace CodeWars.LevelFourTest
{
  public class LevelFourTests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test(Description = "Simple RangeExtraction tests")]
    public void RangeExtractionTests()
    {
      //Assert.That(RangeExtraction.Extract(new[] { 1 }), Is.EqualTo("1"));
      Assert.That(RangeExtraction.Extract(new[] { 1, 2 }), Is.EqualTo("1,2"));
      Assert.That(RangeExtraction.Extract(new[] { 1, 2, 3 }), Is.EqualTo("1-3"));

      Assert.That(
          RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }), 
          Is.EqualTo("-6,-3-1,3-5,7-11,14,15,17-20"));

      Assert.That(
          RangeExtraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }), 
          Is.EqualTo("-3--1,2,10,15,16,18-20"));
      
      Assert.That(
          RangeExtraction.Extract(new[] { -163, -161, -159, -157, -155, -153, -152, -151, -150, -148, -146, -145, -143, -141, -139, -137, -135, -133, -132, -130, -128, -127, -126, -124, -122, -121, -120, -118, -117, -115, -113, -111, -109, -108, -106, -105, -103, -101, -100, -98, -96, -95, -94, -92, -91, -89, -88, -86, -84, -82, -81, -80, -78, -76, -75, -73, -72, -70, -68, -67, -66, -65, -64, -62, -60, -58, -57, -55, -53, -52, -51, -50, -48, -46, -44, -43, -41, -39, -37, -35, -34, -33, -32, -31, -29 }),
          Is.EqualTo("-163,-161,-159,-157,-155,-153--150,-148,-146,-145,-143,-141,-139,-137,-135,-133,-132,-130,-128--126,-124,-122--120,-118,-117,-115,-113,-111,-109,-108,-106,-105,-103,-101,-100,-98,-96--94,-92,-91,-89,-88,-86,-84,-82--80,-78,-76,-75,-73,-72,-70,-68--64,-62,-60,-58,-57,-55,-53--50,-48,-46,-44,-43,-41,-39,-37,-35--31,-29"));
    }

    [TestFixture]
    public class AddingBigNumbersTest
    {
      [Test]
      public void AddTest()
      {
        Assert.That(AddingBigNumbers.Add("91", "19"), Is.EqualTo("110"));
        Assert.That(AddingBigNumbers.Add("123456789", "987654322"), Is.EqualTo("1111111111"));
        Assert.That(AddingBigNumbers.Add("999999999", "1"), Is.EqualTo("1000000000"));

        Assert.That(AddingBigNumbers.Add("823094582094385190384102934810293481029348123094818923749817", 
          "234758927345982475298347523984572983472398457293847594193837"), 
          Is.EqualTo("1057853509440367665682450458794866464501746580388666517943654"
));

        Assert.That(AddingBigNumbers.Add("234859234758913759182357398457398474598237459823745928347538", 
          "987429134712934876249385134781395873198472398562384958739845"), 
          Is.EqualTo("1222288369471848635431742533238794347796709858386130887087383"
));

        Assert.That(AddingBigNumbers.Add("854694587458967459867923420398420394845873945734985374844444", 
          "333333333333439439483948394839834938493843948394839432322229"), 
          Is.EqualTo("1188027920792406899351871815238255333339717894129824807166673"
));

        Assert.That(AddingBigNumbers.Add("666666665656566666666565656666666656565666666665656566666666", 
          "464646464646464644646464646464646464646464646463463463463466"), 
          Is.EqualTo("1131313130303031311313030303131313121212131313129120030130132"
));

        Assert.That(AddingBigNumbers.Add("987429134712934876249385134781395873198472398562384958739845234859234758913759182357398457398474598237459823745928347538", 
          "835743829547328954732895474893754893753281957319857432958432548937859483265893274891378593187431583942678439217431924789"), 
          Is.EqualTo("1823172964260263830982280609675150766951754355882242391698277783797094242179652457248777050585906182180138262963360272327"
));
      }
    }

    [Test]
    public void SnailTest1()
    {
      int[][] array =
      {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
      var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
      Test1(array, r);

      int[][] array2 =
      {
                new []{1, 2, 3},
                new []{8, 9, 4},
                new []{7, 6, 5}
            };
      var r2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      Test2(array2, r2);

      int[][] array3 =
      {
          new []{1, 2, 3, 4},
          new []{5, 6, 7, 8},
          new []{9, 10, 11, 12},
          new []{13, 14, 15, 16},
      };
      var r3 = new[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };
      Test3(array3, r3);

      int[][] array4 =
      {
          new []{1},

      };
      var r4 = new[] { 1 };
      Test4(array4, r4);

      int[][] array5 =
      {
          Array.Empty<int>(),
      };
      var r5 = Array.Empty<int>();
      Test5(array5, r5);
    }

    public string Int2dToString(int[][] a)
    {
        return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
    }

    public void Test1(int[][] array, int[] result)
    {
      var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
      Console.WriteLine(text);
      Assert.That(SnailSort.Snail(array), Is.EqualTo(result));
    }

    public void Test2(int[][] array, int[] result)
    {
      var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
      Console.WriteLine(text);
      Assert.That(SnailSort.Snail(array), Is.EqualTo(result));
    }
    public void Test3(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            Assert.That(SnailSort.Snail(array), Is.EqualTo(result));
        }
        public void Test4(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            Assert.That(SnailSort.Snail(array), Is.EqualTo(result));
        }

        public void Test5(int[][] array, int[] result)
        {
            var text = $"{Int2dToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            Assert.That(SnailSort.Snail(array), Is.EqualTo(result));
        }


    }

  public class SumOfIntervalTest
  {
    [Test]
    public void ShouldHandleEmptyIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { }), Is.EqualTo(0));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }), Is.EqualTo(0));
    }

    [Test]
    public void ShouldAddDisjoinedIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }), Is.EqualTo(9));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }), Is.EqualTo(11));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }), Is.EqualTo(7));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }), Is.EqualTo(78));
    }

    [Test]
    public void ShouldHandleNegativeIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-332_642_732, -326_840_777), (-496_175_526, -488_321_420), (-284, -276), (11, 15) }), Is.EqualTo(13_656_073));     
    }

    [Test]
    public void ShouldAddAdjacentIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }), Is.EqualTo(54));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }), Is.EqualTo(23));
    }

    [Test]
    public void ShouldAddOverlappingIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }), Is.EqualTo(7));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }), Is.EqualTo(6));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }), Is.EqualTo(19));
    }

    [Test]
    public void ShouldHandleMixedIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }), Is.EqualTo(13));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }), Is.EqualTo(1234));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }), Is.EqualTo(158));
    }

    [Test]
    public void ShouldHandleLargeIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (-1_000_000_000, 1_000_000_000) }), Is.EqualTo(2_000_000_000));
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (0, 20), (-100_000_000, 10), (30, 40) }), Is.EqualTo(100_000_030));
    }

    [Test]
    public void InsaneIntervals()
    {
      Assert.That(SumOfIntervals.SumIntervals(new Interval[] { (83, 99), (406, 425), (443, 454), (-396, -381), (-381, -375), (257, 276), (246, 262), (-460, -446), (-324, -314), (74, 77), (-317, -302), (-241, -235), (442, 461), (446, 455), (-222, -204), (411, 418), (152, 166), (182, 188), (321, 323) }), Is.EqualTo(190));
    }
  }
}