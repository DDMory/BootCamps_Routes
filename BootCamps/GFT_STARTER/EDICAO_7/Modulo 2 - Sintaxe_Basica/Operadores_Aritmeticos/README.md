# Operadores Aritméticos em C\#

Os operadores aritméticos são os operadores usados na matemática para a realização de cálculos, ela também é aplicada em programação para realizar as operações.
- Adição: `+` --> `a + b`
- Subtração: `-` --> `a - b`
- Multiplicação: `*` --> `a * b`
- Divisão: `/` --> `a / b`
- Modulo: `%` --> `a % b`
- Incremento: `++` --> `a++`
- Decremento: `--` --> `b--`

```C#
/* Classe Calculadora */
using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

  

namespace Operadores_Aritmeticos.models

{

    public class Calculadora

    {

        public void Somar(int x, int y)

        {

            Console.WriteLine($"{x} + {y} = " + (x + y));

        }

  

        public void Subtrair(int x, int y)

        {

            Console.WriteLine($"{x} - {y} = " + (x - y));

        }

  

        public void Multiplicar(int x, int y)

        {

            Console.WriteLine($"{x} * {y} = " + (x * y));

        }

  

        public void Dividir(int x, int y)

        {

            if (y == 0)

                Console.WriteLine("Divisão por zero!!!");

            else Console.WriteLine($"{x} / {y} = " + (x / y));

        }

    }

}
///////////////////////////////////////////////////////////////////////
/* Codigo 'principal' */
using Operadores_Aritmeticos.models;

  

Calculadora calc = new Calculadora();

  
//saida: 32 + 13 = 45
calc.Somar(32, 13);

//saida: 32 - 13 = 19
calc.Subtrair(32, 13);

//saida: 32 / 13 = 2
calc.Dividir(32,13);
```

Também é possível realizar operações mais complexas, como a potencia. Para casos assim, usamos a classe `Math`, que pode realizar algumas das operações matemáticas complexas 

```C#

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

  

namespace Operadores_Aritmeticos.models

{

    public class Calculadora

    {
		/* ... */
        /* Restando do codigo */

		/* Math.pow() */
        public void Potencia(int x, int y)

        {

            Console.WriteLine($"{X}^{Y} = " + Math.Pow(x,y));

        }

    }

}
```

Outros exemplos de aplicação da classe `Math`:
- `Seno` e `Cosseno`:
```C#
public void Seno(double angulo){

	double radiano = ((angulo * Math.PI) / 180);
	double seno = Math.Sin(radiano);
	
	Console.WriteLine($"Seno do angulo {angulo} é {seno}");
}

  

public void Cosseno(double angulo){

	double radiano = ((angulo * Math.PI) / 180);
	double cos = Math.Cos(radiano);

	Console.WriteLine($"Seno do angulo {angulo} é {cos}");
}
```

- `Raiz quadrada`:
```C#
 public void RaizQuadrada(int x){

	double raiz = Math.Sqrt(x);

	Console.WriteLine($"Raiz quadrada de {x} é igual a {raiz}");
}
```

