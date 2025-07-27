using Sintaxe_Identação.models;

Pessoa p = new Pessoa();
p.Nome = "Doulgas";
p.Idade = 21;
p.Apresentar();

string saudação = "Ola pessoa, prazer te conhecer";
int quantidade = 32;
double preco = 12.52;
bool condicao = true;

Console.WriteLine("saudação: " + saudação);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine($"Preço: RS {preco}");
Console.WriteLine("Valor da " + $"Variavel {condicao}");