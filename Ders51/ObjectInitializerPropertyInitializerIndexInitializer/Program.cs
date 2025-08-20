using ObjectInitializerPropertyInitializerIndexInitializer;

//constructor ile
StudentName studentName = new StudentName("Nazım hikmet", "Ran", "Ben bir ceviz ağacıyım gülhane parkında");

//Object initializer ile
StudentName studentName1 = new StudentName
{
    FirstName = "Nazım hikmet",
    LastName = "Ran",
    Poem = "Ceviz ağacı",
    Id = 1
};

//Sadece bir propertiye değer vermek(Set etmek)
StudentName studentName2 = new StudentName
{
    Id = 34567890
};