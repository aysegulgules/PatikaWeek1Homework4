Console.WriteLine("Rüya Manavina Hoş Geldiniz! ");

//Rüya manavındaki meyve fiyatları
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.WriteLine("\n---------------------------------\n");
Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
string fruit=(Console.ReadLine()).ToUpper();//ToUpper ile büyük harfe çevriliyor
int price;

// switch ile kontrol
switch (fruit)
{
    case "ELMA":
        price = 2;
        break;
    case "ARMUT":
        price = 3;
        break;
    case "ÇİLEK":
        price = 2;
        break;
    case "MUZ":
        price = 3;
        break;
    default:
        price = 4;
        break;
}


Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{price} TL");

Console.WriteLine("\n--------------------------\n");

Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
string fruit1 = (Console.ReadLine()).ToUpper();//ToUpper ile büyük harfe çevriliyor
int price1;


// if-else ile kontrol

if (fruit1 == "ELMA")
{  
    price1 = 2;
}
else if(fruit1 == "ARMUT")
{  
    price1 = 3;
}
else if (fruit1 == "ÇİLEK")
{
    price1 = 2;
}
else if (fruit1 == "MUZ")
{
    price1 = 3;
}
else 
{
    price1 = 4;
}


Console.WriteLine($"Seçtiğiniz meyvenin fiyatı:{price1} TL");

/* Bu tür uygulamalar için Switch-Case karar yapısının  okunurluğu 
   if/else karar yapısının okunurluğundan daha iyi*/