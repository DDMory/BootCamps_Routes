# Array e Listas em C\#

Uma array é um agrupamento de dados do mesmo tipo. Uma estrutura de dados presente em C# com um tamanho fixo, sua sintaxe é `<TipoDade>[] <nomeVariavel> = new <TipoDado>[Quantidade]`. A array pode ser criada de diversas maneira.

```C#
	int[] array = new int[4]
	int[] array = new int[] {12,32,15,54};
	string[] nome = {"jonas","Lucas", "Abril"};
```

Os valores de uma array podem ser acessadas a partir de seu índice, vale lembrar que a contagem do índice começa do 0.

```C#
int[] array = new int[] {12,32,15,54};

//Acessar o valor 12
Console.WriteLine(array[0])
//Acessar o valor 54
Console.WriteLine(array[3])

//Alterar o valor de indice 2: [15]
array[2] = 43
```

Para conseguirmos acessar cada valor em cada indice da array, usamos as estruturas de repetição.

```C#
//Criar uma array
int[] numerosPare = new int[] { 2, 4, 6, 8, 10, 12 };

//percorrer esse vetor
for (int i = 0; i < numerosPare.Length; i++)
    Console.WriteLine($"[{i}] = {numerosPare[i]}");
```