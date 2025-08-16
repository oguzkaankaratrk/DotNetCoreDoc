///List<T> : t Bir generic sınıftır.  içerisinde veri göndeiririz.  
///Aynı türden elemanların saklanmasını sağlar. 
///Tür güvenliliğini sağlar : Bir değişkenin yalnızca tanımlandığı türden veriler içermesini garanti eder. 
///örneğin, int değişkeninine yalnızca tamsayı  gönderilmesini garanti eder. 
///List<string> : yalnızca sytring liste gönderebilir veya ekleye bilirsin. 
///


//liste oluşturma
//List<int> numbers = new List<int>();

////listeye tek tek veri ekleme
//numbers.Add(1);


////listeye toplu veri ekleme
//numbers.AddRange(new int[] { 2, 3, 4, 654, 765432, 9, });

//// listedeki elemana erişim
//Console.WriteLine(numbers[6]);

////değer silinir, index silinmez //sadece ahmet silinir, sıra silinmez
//numbers.Remove(765432); //değer siliyor.





////index ile değer silinir. // ahmet ile beraber sırası başka sınıfa taşınır. 
//numbers.RemoveAt(0);

////tüm elemanları yazdırma
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}


////listeyi sorgulama veya sıralama
//bool exists = numbers.Contains(1);  //arama
//numbers.Sort(); //sıalama

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
