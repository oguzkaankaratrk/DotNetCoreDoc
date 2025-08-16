// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//endpointler bir uygulamada clientin sunucu ile etkileşimde
//bulunmak için kullandığı url lerdir..
static async Task<int> GetPageLengthAsync(string endpoint)
{
    var client = new HttpClient();
    var uri = new Uri(endpoint);
    byte[] content = await client.GetByteArrayAsync(uri);
    return content.Length;
}

//senkron programlama, bir işlem başladıktan sonra, o işlemin bitmesini beklemeden bir sonraki işleme geçilemez. Sıralı işlemdir. 
//basit işlemlerde kullanılır.
// asenkron programlama, bir işleme başladığındadiğer işleme başlamak için işlemin bitmesini beklemeye gerekyol.
//genellikle ağ isteklerinde, dosya okuma, veri tabanı işlemlerinde kullanılmaktadır.
static void CustomerAge(string url)
{
    url = "www.google.com/userurl";

    Console.WriteLine(url);
}
