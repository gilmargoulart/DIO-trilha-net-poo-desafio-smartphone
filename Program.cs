using DesafioPOO.Models;

Console.Clear();

Smartphone t1 = new Nokia("47999123456", "1100a", "42342934924792634762384", 32);
Console.WriteLine(t1.ToString());
t1.Ligar();
t1.ReceberLigacao();
t1.InstalarAplicativo("Telegrão");

Console.WriteLine("---");

Smartphone t2 = new Iphone("47999123457", "13", "87546546162684646454645", 128);
Console.WriteLine(t2.ToString());
t2.Ligar();
t2.ReceberLigacao();
t2.InstalarAplicativo("WhatsApp");

// Classe Smartphone abstrata, não pemrite instanciar.
// Smartphone t3 = new Smartphone();
