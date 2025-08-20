public class Person
{
    public Person()
    {
        Console.WriteLine("Hello from person's parameterless constructor");
    }

    public required string FirstName
    {
        set
        {
            Console.WriteLine("Hello from setter of person's required property 'First Name'");
        }
    }

    public required string LastName
    {
        set
        {
            Console.WriteLine("Hello from setter of person's required property 'Last Name'");
        }
    }

    public required string City
    {
        set
        {
            Console.WriteLine("Hello from setter of person's required property 'City'");
        }
    }
}

public class Dog
{
    public Dog(int age)
    {
        Console.WriteLine("Hello from Dog's non-parameterless constructor");
    }

    public required string Name
    {
        set
        {
            Console.WriteLine("Hello from setter of Dog's required property 'Name'");
        }
    }
}