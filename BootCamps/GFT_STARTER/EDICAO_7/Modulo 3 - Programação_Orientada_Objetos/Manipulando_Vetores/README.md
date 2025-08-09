# Manipulando Vetores

## String

Por definição, uma string é um conjunto sequencia de caracteres que juntas foram uma frase. Uma string, pode então, ser entendida como a concatenação de caracteres.

A manipulação de Strings para exibição de campos e valores instanciados se dá por meio da concatenação ou da interpolação.

### Concatenação

A concatenação entre palavras, na programação, ocorre por meio do operador de soma, na matemática, quando entre strings `<palavraA> + <palavraB> = <PalavraAB>`.

```C#
int dia = 10

string texto = "amanha tenho aula " + ", mas não quero ir";
string texto2 = "Eu soube que dia " + dia + " é aniversario da Luiza";

/* 
	OUTPUTS ESPERADOS NO CONSOLELOG:
	TEXTO: amanha tenho aula, mas não quero ir
	TEXTO2: Eu soube que dia 10 é aniversario da Luiza
	
*/
```
### Interpolação

A interpolação permite a inserção de dados proveniente de variáveis entre aspas, sua sintaxe é `$""`

```C#
int dia = 10

string texto2 = $"Eu soube que dia {dia} é aniversario da Luiza";
```

Vale ressaltar que tanto concatenação quanto interpolação funcionam internamente no ``Console.WriteLine()``

```C#
int dia = 10

Console.WriteLine($"Eu soube que dia {dia} é aniversario da Luiza");
Console.WriteLine("Eu soube que dia " + dia + " é aniversario da Luiza");
```

### Formatação de String:

Em situações, é necessário que alguns dados venham em um determinado formato, por exemplo, um valor monetário, é necessário que ele possua duas casas decimais, representando os centavos.
A formatação se da por meio da sintaxe: `<Dado>:<formataçao>`.

```C#
decimal valor = 3.32M;

console.WriteLine($"Dado não formatado: {valor} \n formatado {valor:C}");
```

A formatação leva em consideração as informações da configuração do sistema operacional, a formatação tende a alterar de região para região, então para mudarmos a região em nosso programa será necessário inserir o seguinte trecho em seu código, lembrando de substituir o valor entre aspas, "", para a região desejada.

```C#
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
```

Outra maneira de realizar a formação é utilizando o método String que existe em cada tipo de dado.

```C#
decimal valor = 3.32M;

console.WriteLine(valor.ToString("C2")); //Daus casas deciamis
console.WriteLine(valor.ToString("C8")); //Oito casas deciamis
```