var tipoAnonimo = new { Nome = "Matheus", Sobrenome = "Belo", Altura = 1.65 };
Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
Console.WriteLine($"Altura: {tipoAnonimo.Altura}");



// using ExemploExplorando.Models;
// using Newtonsoft.Json;

// string conteudoArquivos = File.ReadAllText("Arquivos/vendas.json");

// List<Vendas> vendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivos);

// foreach (Vendas venda in vendas){
//     Console.WriteLine($"Nome: {venda.Nome}, Preço: {venda.Preco},{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}," : "")} Quantidade: {venda.Quantidade} Data: {venda.Data}");
// }




// using ExemploExplorando.Models;
// using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now;

// Vendas v1 = new Vendas(1, "computador", 3000M, dataAtual);
// Vendas v2 = new Vendas(1, "Material de escritório", 25.00M, dataAtual);
// Vendas v3 = new Vendas(2, "Licença de Software", 110.00M, dataAtual);

// List<Vendas> listaVendas = new List<Vendas>();

// listaVendas.Add(v1); 
// listaVendas.Add(v2);
// listaVendas.Add(v3);
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);







//ternario
// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é: " + (ehPar ? "é par" : "é impar"));





//Deconstruct
// using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa("Matheus", 22);

// (string nome, int idade) = p1;

// Console.WriteLine($"seu nome é {nome} e sua idade é: {idade}");





















// using ExemploExplorando.Models;

// LeituraArquivos arquivos = new LeituraArquivos();

// var (Sucesso, LinhasArquivos, QuantidadeDeLinhas) = arquivos.LerArquivos("Arquivos/arquivoLeitura.txt");

// if (Sucesso)
// {
//     Console.WriteLine($"A quantidade de linhas do seu programa é: {QuantidadeDeLinhas}");
//     foreach (string linhas in LinhasArquivos)
//     {
//         Console.WriteLine(linhas);
//     }
// }

// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }




















// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Matheus", "Leonardo", 1.65M);

// Console.WriteLine($"Id {tupla.Id}");
// Console.WriteLine($"Nome {tupla.Nome}");
// Console.WriteLine($"Sobrenome {tupla.Sobrenome}");
// Console.WriteLine($"Altura {tupla.Altura}");
















// using ExemploExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Matheus";
// p1.Idade = 22;

// Pessoa p2 = new Pessoa();
// p2.Nome = "Laysa";
// p2.Idade = 22;

// Curso CienciaDaComputacao = new Curso();
// CienciaDaComputacao.Nome = "Ciência da Computação";
// CienciaDaComputacao.Alunos = new List<Pessoa>();
// CienciaDaComputacao.AdicionarAluno(p1);
// CienciaDaComputacao.ListarAlunos();

// Curso ADS = new Curso();
// ADS.Nome = "Análise e desenvolvimento de sistemas";
// ADS.Alunos = new List<Pessoa>();
// ADS.AdicionarAluno(p2);
// ADS.ListarAlunos();

// Pessoa p3 = new Pessoa(nome: "Francisco", idade: 24);