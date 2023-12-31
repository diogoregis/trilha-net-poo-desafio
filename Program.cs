using DesafioPOO.Models;

Nokia nokia = new("81966663339", "N95", "788885555222239", 64);
Iphone iphone = new("81999988881", "XS", "977775555222231", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("------------------");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Maps");