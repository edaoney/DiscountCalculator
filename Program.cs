using DiscountCalculator;

Console.WriteLine("AYAKKABILARIMIZDA %30 İNDİRİM VAR!!!");
 
 
var Ayakkabi = new Product  
{
    Products = "Klasik Ayakkabi",
    Fiyat = 2500,
};
Console.Write("Ürün: ");
Console.WriteLine( Ayakkabi.Products); 
Console.Write("Fiyat: "); 
Console.Write(Ayakkabi.Fiyat); 
Console.WriteLine("TL");
Console.Write("İndirimli Fiyatı: ");
Console.Write(Ayakkabi.İndirimHesapla());
Console.Write("TL");
