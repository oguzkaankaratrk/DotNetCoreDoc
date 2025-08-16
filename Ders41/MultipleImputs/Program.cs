//C# Pattern Matching ile Birden fazla özelliğin aynı anda birleştirilmesi, kontrol edilmesi ... dir.

public class Main(string[] args)
{
    //Multiple Input with Property Pattern
    public decimal CalculateDiscount(Order order) => order switch
    {
        { Items: > 10, Cost: > 1000.00m} => 0.10m, //Hem ürün sayısı 10 dan fazla ise, hemde tutar 1000 den büyük ise -> %10 discount
        { Items: > 5, Cost: > 500.00m} => 0.05m,   //%5 discount
        { Cost: > 250.00m} => 0.025m,              //%2.5 discount
        null => throw new ArgumentNullException(nameof(order)), //Null kontrolü, null ise hata fırlat.
        var someObject => 0m //Diğer tüm durumlarda indirim yok

    };


    //Multiple Input with Positional Pattern()
    public record Order(int Items, decimal Cost);//Deconstruct ile kullanmamız gerekli. 
    public decimal CalculateDiscount2(Order order) => order switch
    {
        (> 10, > 1000.00m) => 0.10m, //Hem ürün sayısı 10 dan fazla ise, hemde tutar 1000 den büyük ise -> %10 discount
        (> 5, > 500.00m) => 0.05m,   //%5 discount
        { Cost: > 250.00m } => 0.025m,              //%2.5 discount
        null => throw new ArgumentNullException(nameof(order)), //Null kontrolü, null ise hata fırlat.
        _ => 0m //Diğer tüm durumlarda indirim yok

    };

}
