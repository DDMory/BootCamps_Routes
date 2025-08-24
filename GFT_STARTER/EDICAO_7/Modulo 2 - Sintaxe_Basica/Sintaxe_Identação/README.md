# Sintaxe e Identação
---
## *Classe*

A ***classe*** está relacionada com conceito de abstração na programação orientada a objeto. A ***abstração*** é a conversão de um objeto do mundo real para a programação, é a representação desse objeto.  

Uma classe é divida em duas partes, os ***atributos***, que são as características do objeto, e os ***métodos***, que representam o que aquele objeto é capaz de fazer.

No VSCode a criação de uma classe, por meio da extensão, é feita da seguinte maneira `Botão direito na pasta -> New C# -> Class`, ao clicar, será pedido para você nomear sua classe. Por convenção, nome de classe começa com letra maiúscula (PascalCase): Pessoa, PessoaFisica, etc

```C#
namespace <Caminho_para_Classe>{

    public class <Nome_da_classe>{
		/* Atributos - <ESTADO-DO-ATRIBUTO> <TIPO-DO-ATRIBUTO> <NOME-DO-ATRIBUTO>*/
		public string Nome { get; set; }
        public int Idade { get; set; }
        
        /*Metodos - <ESTADO-DO-METODO> <TIPO-RETORNO-DO-METODO> <NOME-DO-METODO>*/
        public void Apresentar(){
	        Console.WriteLine($"Olá! Meu come é {Nome}, e tenho {Idade} anos");  
        }	
    }
}
```

Em C#, para usarmos a classe recém criada, precisamos retornar para o arquivo `Program.cs` criada no inicio e escrever o seguinte código. Por convenção, nome de objetos começa com letra minúscula (camelCase): pessoa, maquina, pessoaFisica, maquinaOperada, etc.

```C#
/* using <Caminho_para_classe> */
using Sintaxe_Identação.models;

/* <Nome_da_classe> <Nome_do_objeto> = new <Nome_do_Objeto> */
Pessoa p1= new Pessoa();
```
- `using`: especificar em que pasta está a classe que vamos usar.
- `new`: especificar que algo vai ser instanciado.

Uma classe pode ser instanciada em objetos quantas vezes forem necessários, vale lembrar que os nomes dos objetos devem ser diferentes.

```C#
Pessoa p1= new Pessoa();
Pessoa p2= new Pessoa();
Pessoa p3= new Pessoa();
Pessoa Jose= new Pessoa();
```

- Para atribuirmos os dados de um objeto, usamos a seguinte sintaxe: `<Nome_do_objeto>.<atributo> = <valor>`
- Enquanto que para chamarmos seu método usamos: `<Nome_do_objeto>.<Nome_do_metodo>();`

```C#
p1.nome= "Luis";
p1.idade= 32;

p1.Apresentar();
```

Para usarmos tudo que foi instruído até agora, digite o seguinte código no arquivo `Program.cs` e depois digite `dotnet run` no terminal. A saída esperada é: `Olá! Meu come é Doulgas, e tenho 21 anos`

```C#
using Sintaxe_Identação.models;

Pessoa p = new Pessoa();

p.Nome = "Doulgas";

p.Idade = 21;

p.Apresentar();
```
---
## Tipos de Dados

Existe ao todo 13 tipos de dados primitivos, sendo eles: `string`, `char`, `object`, `bool`, `byte`, `decimal`, `double`, `int`, `float`, `long`, `uin`, `short` e `ulong`.

O atributo `Idade` da classe `Pessoa` anteriormente criada é do tipo `int`, enquanto o atributo `Nome` é do tipo `string`

A atribuição de um tipo para uma variável funciona da mesma maneira que o atributo de uma classe: `<Tipo_dado> <nome> = <valor>`

```C#
string saudação = "Ola pessoa, prazer te conhecer";
int quantidade = 32;
double preco = 12.52;
bool condicao = true;
```

Compile o código abaixo e veja o resultado, pode comentar a secção feita anteriormente
```C#
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
```

Existe um tipo de dado para representar datas em C#, o `DateTime`. Sua atribuição funciona da mesma maneira que visto anteriormente `DateTime <nome_da_variavel> = DateTime`, ele possui alguns metodos já feitos, como por exemplo:  
- ``DateTime.Now``:  Data atual, usando como referencia a data da tua maquina

