# *Introdução a .NET*
----
O .NET é uma plataforma de desenvolvimento unificado open source que permite a construção de sistemas e aplicações. A linguagem C# uma das usadas nesta plataforma.

A plataforma .NET permite a construção de soluções, aplicações e construção para: DESKTOP, WEB, CLOUD, MOBILE, GAMIMG, IoT e AI.

O .NET foi desenvolvido com base na motivação da Microsoft em desenvolver um sistema integrado ao Windows que permitisse o desenvolvimento fácil de aplicativos desktop e web.

## *Diferenças entre .NET Framework (Legado) e .NET*
---
O .NET possui duas ramificações:

- **.NET Framework**: Está amarrado exclusivamente ao Windows;
- **.NET (Core)**: Multiplataforma, ele é executável em Windows, Linux e MacOS sem a necessidade de reescrever todo o código para executar em outra plataforma, além de haver outras melhorias.

### *Compilador*
---

O **compilador** é um programa que realiza a conversão de um código de alto nível para o de baixo nível, algo entendível para o computador.
- ***Código de Baixo Nível***: Representação do código em instruções que o processador do computador consegue executar, mais complexidade.
- ***Código de Alto Nível***: Código adaptado para o entendimento humano, "baixa complexidade"

Ao compilar seu projeto, o compilador do .NET realiza um processo de compilação em todas as classes em seu código, gerando um *Código Intermediário (IL Code)* que é independente da maquina e nos formatos `.exe` e `.dll`, os arquivos gerados estão são enviados para o *JIT COMPILER* que vai realizar a tradução do código intermediário para um formato de arquitetura entendível para sua maquina para então executar o código.

#### *Compilador X Transpilador*

- **Compilador**: Programa que realiza a conversão de uma linguagem de alto nível para uma de baixo nível.
- **Transpilador**: É a conversão de uma linguagem implementada para outro. Uma linguagem de alto nível é convertida para outra linguagem de alto nível

## *Conceitos*

- ***Linguagem Compilada***: Linguagens em que o código fonte é traduzido para o código de maquina
- ***Linguagem Interpretada:*** Linguagens que fazem a leitura e a interpretação diretamente do código fonte, não há um compilador e portanto não será gerado um binário.