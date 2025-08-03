using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var samsung = new Samsung("(11)9 1234-5678", "Samsung Galaxy S21", "123456789012345", 64);
var iphone = new Iphone("(21)9 9876-5432", "iPhone 15", "987654321098765", 128);

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Testando Smartphone Samsung:");
samsung.Ligar();
samsung.InstalarAplicativo("Tinder");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Testando Smartphone iPhone:");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine("--------------------------------------------");