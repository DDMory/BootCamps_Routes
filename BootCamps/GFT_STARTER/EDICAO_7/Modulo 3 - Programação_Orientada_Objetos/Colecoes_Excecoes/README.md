# Exceções e Coleções com C\#

## Exceções 

Diversas vezes ao ocorrer um erro durante a execução de seu código, ele é encerrado, disparando assim uma exceção que é detalhada no console de exibição. As exceções são situações inesperadas que ocorrem na execução do código e que, por padrão, o próprio compilador não é capaz de resolver.

As exceções podem ser tratadas para que assim seu código não seja automaticamente encerrado, esse tratamento se dá por meio da sintaxe `try{}catch{}`.
- **``Try``**: Vai tentar realizar o código que estiver entre chaves, se for bem sucedido, ele pulará o `catch` e executara o restante do código.
- **`Catch`**: Caso o Try seja executado de maneira falha, o catch servira para capturar esse erro, apresentando ele de uma maneira apresentável para o desenvolvedor 

```C#
try
{
    string[] linhas = File.ReadAllLines("meuTexo.txt");
    
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }

}catch (Exception e){

    Console.WriteLine(e.Message);
}
```

As exceções se dividem em `especificas` e `genericas`. Um exemplo de exceção especifica é não conseguir acessar o diretório, ou um arquivo.

A clausula `finally` é opcional, ela acompanha o `TryCatch` e é executada sempre ao final, depois de passar pelo Try e pelo Catch: `Try` --> `Catch` --> `finally`

```C#
try{}
catch (FileNotFoundException e){}
catch (DirectoryNotFoundException e){}
catch (Exception e){}
finally{

    Console.WriteLine("Codigo chegou até aqui");
}
```

## Coleções

Array e lista são exemplos de coleções, que são uma coleção de elementos do mesmo tipo. Coleção, então, é um agrupamento de elementos do mesmo tipo, e elas são:
- ***Queue (fila)***: O primeiro elemento a entrar é o primeiro a sair. Segue a regra ***First In - First Out (FIFO)***.

A criação de uma fila segue a sintaxe `queue<tipo> <Nome_da_Fila> = new queue<tipo>();`

```C#
using Colecoes_Excecoes.models;

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(43);
fila.Enqueue(35);  

foreach (int numero in fila){

    Console.WriteLine(numero);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int numero in fila){

    Console.WriteLine(numero);
}
```

---
- ***Stack (pilha)***: O primeiro elemento a entrar é o ultimo a sair. Segue a regra ***First In - Last Out (FILO)***.

A criação de uma pilha segue a sintaxe `Stack<tipo> <Nome_da_Pilha> = new Stack<tipo>();`

```C#
Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(32);
pilha.Push(2);
pilha.Push(54);
pilha.Push(0);

foreach (int numero in pilha){

    Console.WriteLine(numero);
}

Console.WriteLine($" TIRANDO O ELEMENTO {pilha.Pop()} DA PILHA");

foreach (int numero in pilha){

    Console.WriteLine(numero);

}
```

---
- ***Dictionary (Dicionário)***: Uma coleção de chave-valor que armazena valores únicos sem uma ordem especifica.

A criação de um dictionary segue a sintaxe `Dictionary<<Tipo_Chave>, <Tipo_Valor>> dicionario = new Dictionary<<Tipo_Chave>, <Tipo_Valor>>();

```C#
Dictionary<String, string> dicionario = new Dictionary<String, string>();

dicionario.Add("SP", "São Paulo");
dicionario.Add("BA", "Bahia");
dicionario.Add("MG", "Minas Gerais");

foreach (KeyValuePair<String, String> item in dicionario){

    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Removendo a chave: BA");
dicionario.Remove("BA");

Console.WriteLine("Alterando Valor da chave: SP");
dicionario["SP"] = "São Paulino";

foreach (KeyValuePair<String, String> item in dicionario){

    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";

if (dicionario.ContainsKey(chave))
    Console.WriteLine($"Chave encontrada!!!!\nValor da chave: {dicionario[chave]}");
else
    Console.WriteLine("Chave não encontrada!!!!");
```