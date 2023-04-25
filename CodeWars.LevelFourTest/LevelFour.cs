using CodeWars.LevelFour;

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
}