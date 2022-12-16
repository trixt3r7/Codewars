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
  }
}