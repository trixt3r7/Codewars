namespace Codewars.Fundamentals
{
    public class YoureSquare
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        public static bool IsSquareV1(int n)
        {
            if (n < 0) return false;
            if (n == 0 || n == 1) return true;
            for (int i = 1; i <= n / 2; i++)
            {
                if (i * i == n) return true;
            }
            return false;
        }
    }
}
