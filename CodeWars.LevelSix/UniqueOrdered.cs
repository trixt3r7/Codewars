namespace CodeWars.LevelSix;

public class UniqueOrdered
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
  {
    T previous = default(T)!;
    foreach (T current in iterable)
    {
      if (!current!.Equals(previous))
      {
        previous = current;
        yield return current;
      }
    }
  }

  public static IEnumerable<T> UniqueInOrderV2<T>(IEnumerable<T> iterable)
  {
    return iterable.Where((x, i) => i == 0 || !Equals(x, iterable.ElementAt(i - 1)));
  }

  public static IEnumerable<T> UniqueInOrderV1<T>(IEnumerable<T> iterable)
  {
	if (iterable.Count() <= 1)
	{
	  return iterable;
	}

	List<T> result = new List<T>() { iterable.First() };
	foreach (T item in iterable)
	{
	  if (!Equals(item, result.Last()))
	  {
		  result.Add(item);
	  }
	}
    return result;
  }
}
