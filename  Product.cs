namespace DiscountCalculator;

public class Product
{
    public string Products { get; set; }
    public int Fiyat { get; set; }

    public double İndirimHesapla()
    {
        return  Fiyat - Fiyat * 30 / 100 ;
    }

}