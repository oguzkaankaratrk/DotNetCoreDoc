
////direk veri ekleme
List<string> texts = ["<name>", "Felipe", "Andrey"];

//foreach (var text in texts)
//{

//    Console.WriteLine($"Hello {text.ToUpper()}!"); //yazıları büyük harfe çevirir.
//}



////Felipe
//Console.WriteLine(texts[1]);

//Console.WriteLine($"Texts listesinin içerisinde {texts.Count} tane eleman vardır");

//texts.Add("Mushab");

//Console.WriteLine(texts[3]);

//int age = 1;


//66

//IndexOf : listedeki dizide veya dizlerde veya slice lerde verimizin kaçıncı indexte olduğunu dösterir. 
var index = texts.IndexOf("Felipe");//Felipe öğesini ara

if (index == -1)
{
    Console.WriteLine($"when an item is not found, IndexOf retuns {index}");
}
else
{
    Console.WriteLine($"The texts  {texts[index]} is at index {index}");
}

index = texts.IndexOf("Not Found"); // listede bulunamayan bir öğreyi ara
if (index == -1)
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");


//Liste türünü kullanarak Fibonacci sayı listesini oluşturabiliriz.

