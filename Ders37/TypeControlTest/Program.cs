internal class Program
{
    private static void Main(string[] args)
    {


    }

    public static T MidPoint<T>(IEnumerable<T> sequence)
    {
        if (sequence is IList<T> list)
        {
            return list[list.Count / 2];
        }
        else if (sequence is null)
        {
            throw new ArgumentNullException(nameof(sequence), "Sequence can not be null.");
        }
        else
        {
            int halfLenght = sequence.Count() / 2 - 1;
            if (halfLenght < 0) halfLenght = 0;
            return sequence.Skip(halfLenght).First();
        }
    }
}