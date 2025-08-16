///1. Değer türleri
/// Value types(Değer türler) : System.ValueTypes tan türetilir.
///Değer türler bellekte değerlerini doğrudan içerir.
///Stack(yığın) bellekte saklanır.Heapte (küme bellek) yer kaplamaz.
///Garbage collection sürecine dahil edilmezler bu yüzden performans açısından hızlıdırlar. 
///

public struct Coords
{
    public int x, y;

    public Coords(int xValue, int yValue)
    {
        x = xValue;
        y = yValue;
    }
}