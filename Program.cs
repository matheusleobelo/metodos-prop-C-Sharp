using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Matheus";
p1.Idade = 22;

Pessoa p2 = new Pessoa();
p2.Nome = "Laysa";
p2.Idade = 22;

Curso CienciaDaComputacao = new Curso();
CienciaDaComputacao.Nome = "Ciência da Computação";
CienciaDaComputacao.Alunos = new List<Pessoa>();
CienciaDaComputacao.AdicionarAluno(p1);
CienciaDaComputacao.ListarAlunos();

Curso ADS = new Curso();
ADS.Nome = "Análise e desenvolvimento de sistemas";
ADS.Alunos = new List<Pessoa>();
ADS.AdicionarAluno(p2);
ADS.ListarAlunos();