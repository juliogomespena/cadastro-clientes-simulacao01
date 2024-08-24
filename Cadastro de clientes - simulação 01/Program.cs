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

cliente01.nome = "Julio Gomes Pena";
cliente01.cpf = 45898021809;
DateTime.TryParseExact("02/09/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente01.dataAniversario);
cliente01.profissão = "Desenvolvedor C# NET.";
cliente01.comoConheceu = "Anúncio no google.";
cliente01.endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP";
cliente01.telefone = 1145862516;
cliente01.celular = 11981198884;
cliente01.email = "juliogomespena@gmail.com";
cliente01.observacoes = "Filho do Elias e da Valderez.";
cliente01.dataInclusao = DateTime.Now;
cliente01.clienteAtivo = true;

Cliente cliente02 = new();

cliente02.nome = "Lorena Antunes Rezende Pena";
cliente02.cpf = 46125778415;
DateTime.TryParseExact("26/01/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente02.dataAniversario);
cliente02.profissão = "Gestora de tráfego.";
cliente02.comoConheceu = "Anúncio no instagram.";
cliente02.endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP";
cliente02.telefone = 1145862516;
cliente02.celular = 11973695363;
cliente02.email = "lorenarezende@gmail.com";
cliente02.observacoes = "Filha do Josué e da Adriana.";
cliente02.dataInclusao = DateTime.Now;
cliente02.clienteAtivo = true;

cliente01.ExibirCadastroCliente();
cliente02.ExibirCadastroCliente();