
class Program
{
	static void Main()
	{
		int[] arr = [0, 1, 2, 3, 4,];
		List<int> list = new List<int>();

		for (int x = 5; x <= 10; x++)
		{
			list.Add(x);
		}
		ProcessItems<int>(arr);
		ProcessItems<int>(list);
	}

	static void ProcessItems<T>(IList<T> items)
	{
		Console.WriteLine($"Isreadonly returns 0 for this collection , {items.IsReadOnly}");

		foreach (T item in items)
		{
			Console.WriteLine(item?.ToString());
		}

	}
}
