using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone sm = new Iphone("123", "versão 1", "qualquer", 21);
Smartphone sm2 = new Nokia("332", "versão 32", "algum", 100);

Nokia no = new Nokia("315", "versão 22", "AA32", 64);
Iphone ip = new Iphone("552", "versão A31", "BS443", 225);

Console.WriteLine($"Smartphone [new Iphone]\n {sm.Ligar()} \n {sm.ReceberLigacao()} \n {sm.InstalarAplicativo("Os Simpsons")}");
Console.WriteLine($"Smartphone [new Nokia]\n {sm2.Ligar()} \n {sm2.ReceberLigacao()} \n {sm2.InstalarAplicativo("Jogo da Cobra")}");
Console.WriteLine($"Nokia [new Nokia]\n {no.Ligar()} \n {no.ReceberLigacao()} \n {no.InstalarAplicativo("Valorant Mobile")}");
Console.WriteLine($"Iphone [new Iphone]\n {sm.Ligar()} \n {sm.ReceberLigacao()} \n {sm.InstalarAplicativo("Waze")}");