public class Box<T>
{

    class Holder
    {
        public T? Value;//Dışarıdaki t yi içeride kullanabiliyoruz.
    }
}

//Nested type i static olaraktanımlayabişliriz
public static class NestedTypes
{

}

//Nerede kullanılır
//Uygulama detayını saklamak, 
//Enumerator/Iterator : IEnumurable<T> Uygularken, özel enumarator sınıfını nested private olarak tanımlarız. 
//Builder/ Comparer / Policy: Dış sınıfa özgü strateji ve builder nesnelerini içeride saklamak .
//Yardımcı bir tipinva, name space şişmesini önlemek istiyorsan nested tip kullanırsın. 
//