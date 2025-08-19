//Object Initiallizer
//Normalde bir nesne oluştururken constructor kullanırız.

internal class Person
{
    //prop
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //Parametresiz Constructor(ObjectInitializer için gerekli)
    //Object initializer kullanabilmek için public parametsiz constructor erişilebilir olmalı.
    public Person() //Başlangıç değer nedir.
    {
        
    }

    //Klasik yöntem
    //Parametreli contsructor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;  
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName}, {LastName}, {Age} yaşında");
    }
}