# Propriedades, Métodos e Construtores com C\#
### Propriedades

Ao criamos uma classe que é uma abstração de alguma coisa presenta na vida real quando transferida para o âmbito da programação, existem informações que devem ser acessadas apenas por membros autorizados, o mesmo se aplica na programação, nem todo o sistema deve ter acesso a determinada informação de uma classe. Para prevenir essa situação, usamos as propriedades.

Uma propriedade é uma parte que oferece um mecanismo que regula a leitura, a gravação e a manipulação do valor de um campo em questão.

```C#
namespace Propriedades_Metodos_Construtores.models{
    public class Pessoa{

		/* Criação de propriedades*/
        public string nome { get; set; }
        public int idade { get; set; }
    }
}
```

Essa classe Pessoa, por exemplo, possui duas propriedade, uma chamada ``nome`` e outra ``idade``, e elas são identificadas como propriedades por conta do método ``get`` e ``set`` que está entre chaves.

### Métodos

Os métodos, ou funções, são as ações que uma classe, de um ponto de vista computacional, é capaz de realizar. Na vida real, uma pessoa é capaz de se apresentar, é uma ação dela, o método nada mais que é a representação dessa ação de uma ponto de vista computacional, na programação.

Veja um exemplo da sintaxe de um método.
```C#
public void Apresentar(){

	Console.WriteLine($" Prazer! eu me chamo {nome} e tenho {idade} anoa!!");
}
```

Um método obrigatoriamente vai conter:
- Modificador de Acesso: ``public``
- Tipo de retorno: ``void``
- Nome do Método: ``Apresentar``
Enquanto que opcionalmente ele irá conter parâmetros que ficara entre parênteses
- Parâmetros: ``( )``
Um ponto a ressaltar é que dependendo do `Tipo de retorno` que o método tiver, será obrigatório o uso da palavra reservada `return`

```C#
public int Somar(int a, int B){
	return a + b;
}
```
## Validações

Da maneira que a classe Pessoa foi escrita anteriormente, qualquer valor poderia ser inserido nos campos Nome e Idade, o que não é indicado. Em situações como essas, é necessário que haja uma espécie de validação dos dados e isso é realizado da seguinte maneira

```C#
public class Pessoa{

	private string _nome;
	public string nome{

		get{
			return _nome.ToUpper();
        }
        
		set{
			if (value == "" || value.Length < 3)
	        {
				throw new ArgumentException("O nome não pode ser vazio e nem possuir menos de 3 caracteres");
			}
		
		_nome = value;
	}
}
```

Da maneira como está a classe Pessoa, o campo ``_nome`` da pessoa vai apenas ser preenchido com um dado se `O nome não for vazio [value == ""]` ou se `o nome for maior que 2 digitos [ value.length < 3]`, caso nenhum desses dois sejam atendidos, o código disparará o erro e apresentará a seguinte mensagem no console `O nome não pode ser vazio e nem possuir menos de 3 caracteres`.

```C#
using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

  

namespace Propriedades_Metodos_Construtores.models

{

    public class Pessoa

    {

        private string _nome;

        public string nome{

  

            get => _nome.ToUpper();

            set{

                if (value == "" || value.Length < 3)

                {

                    throw new ArgumentException("O nome não pode ser vazio e nem possuir menos de 3 caracteres");

                }

  

                _nome = value;

            }

        }

  

        private int _idade;

        public int idade

        {

            get => _idade;

            set

            {

                if (value < 0 || value > 110)

                    throw new ArgumentException("Idade invalida!!");

  

                _idade = value;

            }

        }

  
		// Meotodo "Apresentar"
        public void Apresentar()

        {

            Console.WriteLine($" Prazer! eu me chamo {nome} e tenho {idade} anoa!!");

        }

    }

}
```

## Modificadores de Acesso

É possível notar o uso constante das palavras reservadas `public` e `private`. O que essas palavras fazem é limitar quem tem acesso as essas informações.
- ``Public``: Qualquer parte do nosso código tem acesso.
- `Private`: Apenas a própria classe referente é capaz de acessar essa informações
## Construtores

Em classes, os construtores obrigam o programador a fornecer valores iniciais para os campos da classe. Por via de regra as características dos construtores são:
- Possuem o mesmo nome da classe
- Não possuem tipo de retorno
- São declaradas como `Public`
Um construtor pode ser vazio, ou possuir parâmetros. Caso vazio, o usuário não precisará informar valor algum ao instanciar um objeto da classe, caso contrario, ele será obrigado a fornecer os dados pedidos.
```C#
 public Pessoa(string Nome, string SobreNome, int Idade){
            this.nome = Nome;
            this.sobreNome = SobreNome;
            this.idade = idade;
}

public Pessoa(){}
```