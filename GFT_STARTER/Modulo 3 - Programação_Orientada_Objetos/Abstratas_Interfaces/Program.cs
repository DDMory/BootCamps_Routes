using Abstratas_Interfaces.Interfaces;
using Abstratas_Interfaces.models;

Pessoa p1 = new Pessoa("Douglas");
Aluno a1 = new Aluno("Alan");

Computador c1 = new Computador();
Console.WriteLine(c1.ToString());

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(3, 2));
Console.WriteLine(calc.Subtrair(3, 2));
Console.WriteLine(calc.Multiplicar(3, 2));
Console.WriteLine(calc.Dividir(3,2));