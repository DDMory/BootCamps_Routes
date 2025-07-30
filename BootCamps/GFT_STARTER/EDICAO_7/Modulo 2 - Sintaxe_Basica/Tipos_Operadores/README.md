# Tipos de Operadores em C\#
---
## *Atribuição*

O operador de atribuição, `=`, atribui o valor do operando, lado direito, a uma variável, lado direito. Consiste na ideia de atribuir um dado a uma variável. `Valor = A`

```C#

//Atribuindo o valor 10 para a variavel A
int A = 10;
//Atribuindo o valor 32 para a variavel B
int B = 32;


//Atribuindo o resultado de A+B para a variavel C
int C = A + B;

//saida: 42
console.writeLine(C);

C += 2; 

/* 
	[ C +=2 ] É equivalente a [C = C + 2] ou [C = 42 + 2].
	Essa mesma formatação se aplica para qualquer outra operação.
	[ C *=2 ]
	[ C -=2 ]
	[ C +=2 ]
	[ C /=2 ]
*/

//saida: 44
console.writeLine(C);

C = 20;

//saida: 20
console.writeLine(C);
```
---
## *Conversão de tipos de variáveis:*

A linguagem C# é fortemente tipada, ou seja, a criação de uma variável é dependente do tipo de dado, ela necessita que o tipo de dado seja informado no momento de sua criação. 
- `variavel = 32`, vai resultar em erro por que o tipo do dado não foi informado.
- `int variavel = 2`, ira funcionar pois foi informado o tipo de dado no momento da atribuição da variável.

Há casos em que é preciso uma variável receber um valor inteiro que está sendo enviado de dentro de uma string, `int valor = "32"`. Esse tipo de formatação resultará em erro, pois a variável `valor` comporta apenas valores inteiro, enquanto que o valor que ele está recebendo é uma string. Para casos assim, é necessário realizar uma operação chamada ***Cast*** - consiste na mudança do tipo do valor que está sendo atribuído para a variável -, para casos assim, a linguagem já disponibiliza recursos para tal mudança.

- Errado
```C#
int a = "25"

// Resultará em erro
Console.WriteLine(a)
```
- Correto, realizando casting (cast)
```C#
int a = Convert.ToInt32("25")

/*
	Outra maneira de usar cast [ int.Parse("25") ]
	int a = int.Parse("25")
*/

Console.WriteLine(a)
```

### *Diferenças entre `.Parse` e `Convert`*

A diferença entre ambos está no tratamento de valor `null`.
- **`Convert`**: Vai tratar o valor `null` como 0, não resultando em erro.
- **`.Parse`**: Vai resultar em erro, porque informa que o valor não pode ser nulo. Encerrando o programa.

### *Listagem de Algumas Conversões*

- `To String`:  Os demais tipos de dados já vêm com o método `ToString`, permitindo que seus valores sejam representados em String, o mesmo se aplica para classes criadas.
```C#
	int valor = 1234;
	string valorString = valor.ToString();
	
	decimal dinheiro = 12.32;
	string dinheiroString = dinheiro.ToString();
	
	Console.WriteLine(valorString);
	Console.WriteLine(dinheiroString);
	/*
		As conversões podem ser realizadas diretamente na chamada do console
		
		Console.WriteLine(valor.ToString());
		Console.WriteLine(dinheiro.ToString());
	*/
```

Vale ressaltar que algumas conversões acabam por ser redundantes, como por exemplo, converter de ``int`` para ``double``/``float``/``decimal``,  as 3 são capazes de representar o inteiro

### *TryParse*

O `TryParse` é um método que tentar converter um tipo de dado para o tipo que esta realizando essa chamada, `int.TryParse( x, out b)`, ele recebe dois parâmetros, sendo o primeiro o que vai ser convertido, e o segundo a variável que vai guardar essa conversão caso haja sucesso.

```C#
	string a = "15-";
	int b = 0;

	int.TryParse(a, out b)

	Console.WriteLine(b);
	Console.WriteLine("Conversão realizada");
```

No exemplo, caso a conversão seja realizada com sucesso, `b` passa a ter o valor inteiro da conversão de `a`, caso contrario,  `b` continua com seu valor anterior e o código segue compilando normalmente, sem ser encerrado

---
# Operações

## Operações Matemáticas

Com relação a ordem em que operações matemáticas básicas são realizadas, a linguagem C# respeita a ordem tal como é feita na matemática comum. Primeiro realizamos as operações de multiplicação, `*`, e divisão, `/`, em seguida as demais operações de soma, `+`, e subtração, `-`, salvo quando não há a presença de parênteses `()`.
- Prioridade 1: Parênteses.
- Prioridade 2: Multiplicação e divisão.
- Prioridade 3: Soma e Subtração.

## Operações Condicionais

Operações condicionais possibilita a mudança de fluxo de execução do código, indicando que caminho o código deve tomar caso uma determinada condição seja ou não atendida. `Se X < Y, então faça algo, se não, faça outra coisa`. O fluxo é limitado a sim ou não, não havendo um meio termo.

```C#
int quantidadeEstoque = 10;
int quantidadeComprando = 31;

if (quantidadeEstoque >= quantidadeComprando)
	Console.WriteLine("Venda realizada!");
else Console.WriteLine("Quantidade insuficiente no estoque para venda");
```

Observações, caso após ``IF``, ou ``ELSE``, tiver apenas uma linha, as chaves se tornam opcionais.

```C#
int quantidadeEstoque = 10;
int quantidadeComprando = 31;

if (quantidadeEstoque >= quantidadeComprando){
	Console.WriteLine("Venda realizada!");
else{
	Console.WriteLine("Quantidade insuficiente no estoque para venda");
	Console.WriteLine("Necessario reabastecer estoque!!");
}
```

O `IF` avalia apenas condições entre parênteses ``()``, dentro pode ter qualquer comparação entre valores ou informações. Além disso, também é possível guardar essa comparação em uma variável, anterior ao ``IF``, e então colocar ela dentro do ``IF``

```C#
int quantidadeEstoque = 10;
int quantidadeComprando = 31;
bool possivelEfetuarCompra = quantidadeEstoque >= quantidadeComprando;

// Nesse caso, o if vai avaliar se a condição é verdadeira
if (possivelEfetuarCompra){
	Console.WriteLine("Venda realizada!");
else{
	Console.WriteLine("Quantidade insuficiente no estoque para venda");
	Console.WriteLine("Necessario reabastecer estoque!!");
}	
```

Caso necessário a adição de mais clausulas IF após outro IF anteriormente realizado, as clausulas podem ser aninhadas.

```C#
if(/* SUA CONDIÇÃO*/){
} else if (/* Outra condição*/){
} else if (/* Outra condição e assim por diante */){
} else {
}

```

Outra alternativa para caso haja um aglomerado ***IFs*** aninhados, é o ***switch case***. Ele funciona de maneira semelhante ao IF aninhado, permitindo o analise de uma condição e guiando o fluxo do código por um caminho caso alguma condição seja atendida ou não.

```C#
Console.WriteLine("Digite uma letra: ");
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

	/*
			Adicionamos o `break` ao final de cada case
			para que o codigo saia da função em questão e 
			assim não execute os demais cases
	*/
```

### Operadores Lógicos

Os operadores lógicos são os que usamos para escrever nossas operações condicionais, quando precisamos que duas condições diferentes deem resultados diferentes ou iguais.
- ***OR ( ``||`` )***:  Caso pelo menos uma das condições seja verdadeira, o resultado do IF será verdadeiro. 
```C#
bool menorIdade = true;
bool acompanhadoAdulto = true;
bool maiorIdade = false;

// saida: Pode entrar no evento
if(maiorIdade || acompanhadoAdulto){
	Console.WriteLine("Pode entrar no evento");
} else {
	Console.WriteLine("Não pode entrar no evento");
}
```

- ***AND ( ``&&``)***: Caso ambas condições sejam iguais, seu resultado é verdadeiro. Caso uma das condições seja diferente da outra, seu resultado é falso
```C#
bool menorIdade = true;
bool acompanhadoAdulto = true;
bool maiorIdade = false;

//saida: Pode entrar no evento
if(menorIdade && acompanhadoAdulto){
	Console.WriteLine("Pode entrar no evento");
} else {
	Console.WriteLine("Não pode entrar no evento");
}
```

- ***NOT (`!`)***: É o operador de negação, ele tende a inverter o valor da variável, colocando sua negação
```C#
bool passeiDeAno = true;

// saida: Passou de ano
if(!passeiDeAno){
	Console.WriteLine("Passou de ano");
} else {
	Console.WriteLine("Não passou de ano");
}
```
