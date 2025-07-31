# Estruturas de Repetição

São trechos de código que se repetem diversas vezes enquanto uma determinada condição não é atingida. São estruturas bem comuns, sendo encontradas praticamente em qualquer código e são utilizadas de três maneira: `For`, `While` e `Do-While`

## For:

É uma das estruturas de repetição, sua sintaxe é `for( <inicio>; <condição>; <atualização de inicio>  )`, onde:
- *`Inicio`*: É o estado inicial da repetição, onde ela vai começar a conta
- *`Condição`*: Condição que fará com que o loop se repita até ser atendida
- *`Atualização de inicio`*:  Atualização do índice inicial para prevenir um loop eterno e que a condição seja cumprida.

A tabuada é um ótimo exemplo das aplicações de estruturas de repetição:
```C#
int numero = 2;

for (int i = 0; i < 10; i++)
	Console.WriteLine($"{numero} * {i + 1} = {((numero) * (i + 1))}");
```

## While:

Também uma das estruturas de repetição, sua sintaxe é  `while(condição)`.
- *`Condição`*: Condição que fará com que o loop se repita até ser atendida

É necessário ter uma atenção extra nessa estrutura por que ela, diferente da estrutura anterior, não possui um parâmetro de inicio, e nem de atualização, então é bastante comum o parâmetro de inicio ser criado fora do While e atualizada dentro da própria estrutura.
```C#
int contador = 0;
numero = 4;
while (contador < 10)
{
	Console.WriteLine($"{numero} * {contador + 1} = {((numero) * (contador + 1))}");
	contador++;
}
```

## Do-While:

Ela é semelhante à estrutura anterior, possui as mesmas atenções da estrutura While, porém com uma característica especial, ela sempre executara o código pelo menos uma vez antes de dar inicio ao loop.
```C#
numero = 10;
contador = 0;
do{
    Console.WriteLine($"{numero} * {contador + 1} = {((numero) * (contador + 1))}");
    contador++;

}while(contador < 10);
```