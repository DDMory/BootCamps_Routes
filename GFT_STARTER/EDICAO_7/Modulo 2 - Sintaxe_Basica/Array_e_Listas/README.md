# Array e Listas em C\#

As vezes é necessário representarmos uma grande quantidade de informações do mesmo tipo de dado durante o decorrer do código. Uma vez que é inviável criarmos estaticamente uma variável para cada valor diferente, as Arrays surgiram como uma solução para essa situação.

## Array:

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

Para conseguirmos acessar cada valor em cada indice da array, usamos as estruturas de repetição, ou o método ForEach.

```C#
//Criar uma array
int[] numerosPare = new int[] { 2, 4, 6, 8, 10, 12 };

//percorrer esse vetor
for (int i = 0; i < numerosPare.Length; i++)
    Console.WriteLine($"[{i}] = {numerosPare[i]}");

//FOREACH
foreach (var valor in numerosPare){
    Console.WriteLine(valor);
}
```

Normalmente, uma array criada de maneira estática não pode ter seu tamanho mudado, mas o C# oferece uma classe `Array` que permite ao usuário manipular sua array, oferecendo métodos capaz de redimensionar uma Array. 
- ``Array.Resize``: Mudar tamanho do Array.
```C#
//Rediomensionar array
int[] numerosPare = new int[] { 2, 4, 6, 8, 10, 12 };

//Sintaxe: Array.Resize(ref <nomeDaArray>, <novoTamanho>);
Array.Resize(ref numerosPare, 6 * 2);
```

- ``Array.Copy``: Copiar uma array para outra array
```C#
//arrays
int[] numerosPares = new int[] { 2, 4, 6, 8, 10, 12 };
int[] numerosParesBackup = new int[numerosPares.Length]

//Sintaxe: Array.Copy( <arraySerCopiado>, <arrayDestino>, <quantidadeElementosCopiados>);
Array.Copy(numerosPares, numerosParesBackup, numerosPares.Length);
```

## Listas:

Listas são um tipo de array, funcionam de maneira semelhante, porém com melhorias  e sem a complexidade de manipulação de array. A sintaxe de uma lista é `List<TipoDado> NomeDaLista = new List<TipoDado>();`

Também podemos manipular Lista, adicionar elementos, remover elementos, percorrer a lista entre muitas outras manipulações disponíveis.

```C#
/* Lista */
List<String> listaPlavras = new List<String>();

//adicionar dados à lista
listaPlavras.Add("Arte");
listaPlavras.Add("Volei");
listaPlavras.Add("Ida");
listaPlavras.Add("Vinda");

//remover um elemento
listaPlavras.Add("Volei");

//percorrer a lista
//For
Console.WriteLine($"METODO FOR PARA PERCORRER LISTAS");
for (int i = 0; i < listaPlavras.Count; i++)
    Console.WriteLine($"Palavra {i} = {listaPlavras[i]}");

  

//ForEach
Console.WriteLine($"METODO FOREACH PARA PERCORRER LISTAS");
foreach (string item in listaPlavras)

    Console.WriteLine($"Palavra = {item}");
```