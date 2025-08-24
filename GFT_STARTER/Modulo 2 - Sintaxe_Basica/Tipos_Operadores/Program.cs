
/* Operações - Atribuições */
    //Atribuindo o valor 10 para a variavel A
    int A = 10;
    //Atribuindo o valor 32 para a variavel B
    int B = 32;

    //Atribuindo o resultado de A+B para a variavel C
    int C = A + B;

    Console.WriteLine(C);


/* Operações - Conversão */
    //String -> Int
    int a = Convert.ToInt32("25");

    Console.WriteLine(a);

    // Int/decimal/etc -> String
    int valor = 1234;
	string valorString = valor.ToString();
	
	decimal dinheiro = 12.32M;
	string dinheiroString = dinheiro.ToString();
	
	Console.WriteLine(valorString);
	Console.WriteLine(dinheiroString);

    //TryParse
	string stringEstranha = "15-";
	int valorStringEstranha = 0;

    int.TryParse(stringEstranha, out valorStringEstranha);

	Console.WriteLine(valorStringEstranha);
	Console.WriteLine("Conversão realizada");


/* Operações -  Condicionais */

    int quantidadeEstoque = 10;
    int quantidadeComprando = 31;

    if (quantidadeEstoque >= quantidadeComprando)
        Console.WriteLine("Venda realizada!");
    else Console.WriteLine("Quantidade insuficiente no estoque para venda");

    /* Switch Case */
    Console.Write("Digite uma letra: ");
    string letra = Console.ReadLine();

    switch(letra){
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("É uma vogal");
            break;
        
        default:
            
            Console.WriteLine("Não é uma vogal");
            break;
    }
