using Propriedades_Metodos_Construtores.models;

Pessoa pessoa = new Pessoa("Jose", "Luiser", 32);

Pessoa pessoaA = new Pessoa( Nome: "Alan", SobreNome : "Morreira", Idade: 12);

Pessoa pessoaB = new Pessoa();
pessoaB.nome = "Davy";
pessoaB.sobreNome = "Jovas";
pessoaB.idade = 23;

pessoa.Apresentar();
pessoaA.Apresentar();
pessoaB.Apresentar();

Curso curso = new Curso();
curso.nome = "DIO - GFT";
curso.alunos = new List<Pessoa>();
curso.AdicionarAluno(pessoa);
curso.AdicionarAluno(pessoaA);
curso.AdicionarAluno(pessoaB);
curso.ListarAlunos();