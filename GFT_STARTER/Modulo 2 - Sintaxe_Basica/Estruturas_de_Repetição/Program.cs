int numero = 2;


Console.WriteLine("Sou a estrutura FOR!!");
for (int i = 0; i < 10; i++)
    Console.WriteLine($"{numero} * {i + 1} = {((numero) * (i + 1))}");

Console.WriteLine("\n\nSou a estrutura WHILE!!");
int contador = 0;
numero = 4;
while (contador < 10)
{
    Console.WriteLine($"{numero} * {contador + 1} = {((numero) * (contador + 1))}");
    contador++;
}

Console.WriteLine("\n\nSou a estrutura DO-WHILE!!");
numero = 10;
contador = 0;

do
{
    Console.WriteLine($"{numero} * {contador + 1} = {((numero) * (contador + 1))}");
    contador++;
} while (contador < 10);

bool menu = true;
string op;
while (menu)
{
    Console.WriteLine("========= MENU DE OPÇÕES!!!! =========");
    Console.WriteLine(" 1 - Cadastrar Cliente ");
    Console.WriteLine(" 2 - Atualizar Cliente ");
    Console.WriteLine(" 3 - Visualizar Cliente");
    Console.WriteLine(" 4 - Deletar Cleinte ");
    Console.WriteLine(" 5 - Encerrar aplicação\n\n");

    op = Console.ReadLine();

    switch(op){
        case "1":
            Console.WriteLine(" Cadastrando Cliente \n");
            break;
        case "2":
            Console.WriteLine(" Atualizando Cliente \n");
            break;
        case "3":
            Console.WriteLine(" Visualizando Cliente \n");
            break;
        case "4":
            Console.WriteLine(" Deletando Cliente \n");
            break;
        case "5":
            Console.WriteLine(" Encerrando navegação \n");
            menu = false;
            break;
        default:
            Console.WriteLine(" OPÇÃO INVALIDA \n");
            break;
    }
}