# Projeto ASP.NET Com Minimals APIs

Criação de uma API utilizando a técnica de Minimals APIs para o registro de veículos, ampliando suas funcionalidades ao incorporar administradores com regras JWT

## Ferramentas Usadas:

- VSCode
- PostMan

## Criação de Projeto Web Base

1. Abra o Terminal;
2. Digite `dotnet new web -o <Nome_do_Projeto>`.

## Linhas de Comando para instalação de dependencias

Aviso: Lembre-se de fazer as alterações necessárias de versão para que as dependencias consigam se comunicar

- Core: `dotnet add package Microsoft.EntityFrameworkCore --version 9.0.8`
- Desing: ``dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.8``
- Tools: `dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.8`
- MySql: `dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3`
- Swagger: ``dotnet add package Swashbuckle.AspNetCore.Swagger --version 9.0.3``