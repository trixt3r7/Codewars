using Codewars.Fundamentals;

namespace CodeWars.FundamentalsTest;

public class YoureSquareTest
{
    [Test]
    public static void ShouldWorkForSomeExamples()
    {
        Assert.That(YoureSquare.IsSquare(-1), Is.EqualTo(false), "negative numbers aren't square numbers");
        Assert.That(YoureSquare.IsSquare(0), Is.EqualTo(true), "0 is a square number (0 * 0)");
        Assert.That(YoureSquare.IsSquare(1), Is.EqualTo(true), "1 is a square number");
        Assert.That(YoureSquare.IsSquare(2), Is.EqualTo(false), "2 isn't a square number");
        Assert.That(YoureSquare.IsSquare(3), Is.EqualTo(false), "3 isn't a square number");
        Assert.That(YoureSquare.IsSquare(4), Is.EqualTo(true), "4 is a square number");
        Assert.That(YoureSquare.IsSquare(25), Is.EqualTo(true), "25 is a square number");
        Assert.That(YoureSquare.IsSquare(26), Is.EqualTo(false), "26 isn't a square number");
    }
}
