using static DictionaryInitializer.ToDictionaryInitializer;

static void Main()
{
    var students = new Dictionary<int, StudentName>()
    {
        {111, new StudentName{Name="mushab",LastName="Güldemir",ID=1123} },
        {112, new StudentName{Name="murat",LastName="demir",ID=123}}
    };

    foreach (var index in Enumerable.Range(112, 3))
    {
        Console.WriteLine($"student {index} is {students[index].Name} {students[index].LastName}");
    }
    Console.WriteLine();

    var students2 = new Dictionary<int, StudentName>()
    {
        [111] = new StudentName{Name="mushab",LastName="Güldemir",ID=1123},
        [112] = new StudentName{Name="murat",LastName="demir",ID=123}
    };

    foreach (var index in Enumerable.Range(1123, 3))
    {
        Console.WriteLine($"student {index} is {students2[index].Name} {students2[index].LastName}");
    }
    Console.WriteLine();
}