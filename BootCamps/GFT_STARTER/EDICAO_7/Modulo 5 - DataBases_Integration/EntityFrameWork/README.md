# Entity Framework

O ***Entity Framework*** (EF) é um framework ***ORM*** (*Object-Relational Mapping*). Criado para facilitar a integração com o banco de dados, mapeando tabelas e gerando comando SQL de forma automática.

Em um banco de dados, somos capazes de utilizar comandos SQL para a realização de operações que compõem um ***CRUD***.
- C - CREATE (Insert)
- R - READ (Select)
- U - UPDATE (Update)
- D - DELETE (Delete)

Com EF, somos capazes de realizar uma tradução de uma classe, escrita na linguagem C#, para comandos SQL. Onde temos uma classe, agora vamos ter seu reflexo em tabela.
![](Images/Pasted%20image%2020250821203433.png)  

Apesar do EF gerar os comando SQL de maneira dinâmica, os comandos de geração de tabela precisam ser guiadas, informando ao entity como proceder com relações às alterações de classes que devem ser refletidas no SQL. 

Para isso EF é capaz de realizar mapeamentos das classes para transformar elas em tabelas, essa operação é chamada ***`Migrations`***. Segue a sintaxe de sua utilização: `dotnet-ef migrations add <Nome_Migration>`

|         Terminal         |  Estrutura de Arquivos  |
| :----------------------: | :---------------------: |
| ![](Images/terminal.png) | ![](arvoreArquivos.png) |

Após qualquer adição de uma migration, é necessário executar o comando `dotnet-ef database update` para que as alterações feitas reflitam no banco de dados.


|            Terminal            | Estrutura de Arquivos |
| :----------------------------: | :-------------------: |
| ![](Images/databaseUpdate.png) | ![](Images/mysql.png) |

## Criação de projeto padrão

Para a criação de um projeto padrão, recomenda-se dar uma olhada em [Modulo 4 - APIs](https://github.com/DDMory/BootCamps_Routes/tree/main/BootCamps/GFT_STARTER/EDICAO_7/Modulo%204%20-%20APIs)

### Pacotes Utilizados:

- EF Desing: ``dotnet add package Microsoft.EntityFrameworkCore.Design``
- EF SqlServer: ``dotnet add package Microsoft.EntityFrameworkCore.SqlServer``
