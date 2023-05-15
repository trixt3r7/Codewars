namespace CodeWars.LevelFive
{
    public class FindTheSmallest
    {
        // NOT SOLVED
        public static long[] Smallest(long n)
        {
            // Move one of the digits in 'n' to get the lowest possible value and return the value and which indexes that switched places
            // If there are multiple solutions return the one with the lowest index
            // If there are no solutions return the original value of 'n'
            List<long> result = new List<long>();
            List<int> numbers = n.ToString().Select(c => (int)(c - 48)).ToList();
            int lowIndex = numbers.FindIndex(i => i == numbers.Min());

            if (lowIndex == 0)
            {
                int minValue = numbers[lowIndex];
                lowIndex = numbers.FindIndex(i => i == numbers.Skip(1).Min());
                minValue = numbers[lowIndex];
                numbers.RemoveAt(lowIndex);
                numbers.Insert(1, minValue);
                result.Add(Convert.ToInt64(String.Join("", numbers)));
                result.Add(lowIndex);
                result.Add(1);
                return result.ToArray();
            }
            else
            {
                int minValue = numbers[lowIndex];             
                numbers.RemoveAt(lowIndex);
                numbers.Insert(0, minValue);
                result.Add(Convert.ToInt64(String.Join("", numbers)));

                if (minValue == 0 && lowIndex < 2)
                {
                    result.Add(0);
                    result.Add(lowIndex);
                }
                else
                {
                    result.Add(lowIndex);
                    result.Add(0);
                }

                return result.ToArray();
            }
        }
    }
}
