//Class Cliente
//Atributos->
//public string nome;
//public long cpf;
//public DateTime dataAniversario = new DateTime();
//public string profissão;
//public string comoConheceu;
//public string endereco;
//public long telefone;
//public long celular;
//public string email;
//public string observacoes;
//public DateTime dataInclusao = new DateTime();
//
//
//
//Métodos->
//ExibirCadastroCliente()

using System.Globalization;

Cliente cliente01 = new();

cliente01.Nome = "Julio";
cliente01.Sobrenome = "Gomes Pena";
cliente01.Cpf = 45898021809;
DateTime.TryParseExact("02/09/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente01.DataAniversario);
cliente01.Profissao = "Desenvolvedor C# NET.";
cliente01.ComoConheceu = "Anúncio no google.";
cliente01.Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP";
cliente01.Telefone = 1145862516;
cliente01.Celular = 11981198884;
cliente01.Email = "juliogomespena@gmail.com";
cliente01.Observacoes = "Filho do Elias e da Valderez.";
cliente01.ClienteAtivo = true;

Cliente cliente02 = new();

cliente02.Nome = "Lorena";
cliente02.Sobrenome = "Antunes Rezende Pena";
cliente02.Cpf = 46125778415;
DateTime.TryParseExact("26/01/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente02.DataAniversario);
cliente02.Profissao = "Gestora de tráfego.";
cliente02.ComoConheceu = "Anúncio no instagram.";
cliente02.Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP";
cliente02.Telefone = 1145862516;
cliente02.Celular = 11973695363;
cliente02.Email = "lorenarezende@gmail.com";
cliente02.Observacoes = "Filha do Josué e da Adriana.";
cliente02.ClienteAtivo = false;



cliente01.ExibirCadastroCliente();
cliente02.ExibirCadastroCliente();