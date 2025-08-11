using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Instânciando um objeto da classe Nokia
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456789", "N98", "5555555", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------");

// Instânciando um objeto da classe Iphone
Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("247856987", "11", "4444444", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
