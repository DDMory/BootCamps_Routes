using Abstracao_Encapsulamento.models;

/*
    ABSTRAÇÃO
    ============
    A abstração é capacidade de representarmos objetos da vida real no conceito de programação,
    é a transformação desse objeto real para o "digital".

    ENCAPSULAMENTO
    ============
    É a capacidade de proteger uma classe, definindo limites para a alteração de uma de suas 
    propriedades.

    HERANÇA
    ============
    Herança é a capacidade de uma classe em herdar atributos e metodos de outra classe.
    Uma classe filha herda de uma classe 
    
    POLIMORFISMO
    ============
    É a capacidade de sobreescrever metodos das classes filhas para que se comportem de 
    maneira defetente

*/

Pessoa p1 = new Pessoa();
p1.Nome = "Steve";
p1.Idade = 12;
p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(23, 5000);
c1.ExibirSaldo();
c1.Sacar(1000);
c1.ExibirSaldo();

Aluno a1 = new Aluno();
a1.Nome = "Felipe";
a1.Idade = 32;
a1.Nota = 9.9;
a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "Aguiar";
pr1.Idade = 27;
pr1.Salario = 32.000M;
pr1.Apresentar();