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


//Cria e atribui infomrações ao cliente01
Cliente cliente01 = new();

cliente01.Nome = "Julio";
cliente01.Sobrenome = "Gomes Pena";
cliente01.Cpf = 45898021809;
DateTime.TryParseExact("02/09/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente01.DataAniversario);
cliente01.Profissao = "Desenvolvedor C# NET.";
cliente01.ComoConheceu = "Anúncio no google.";
cliente01.Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP";
cliente01.Telefone = "1145862516";
cliente01.Celular = "11981198884";
cliente01.Email = "juliogomespena@gmail.com";
cliente01.Observacoes = "Filho do Elias e da Valderez.";
cliente01.ClienteAtivo = true;


//Cria e atribui informações ao cliente02
Cliente cliente02 = new();

cliente02.Nome = "Lorena";
cliente02.Sobrenome = "Antunes Rezende Pena";
cliente02.Cpf = 46125778415;
DateTime.TryParseExact("26/01/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente02.DataAniversario);
cliente02.Profissao = "Gestora de tráfego.";
cliente02.ComoConheceu = "Anúncio no instagram.";
cliente02.Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP - Brazil";
cliente02.Telefone = "1145862516";
cliente02.Celular = "11973695363";
cliente02.Email = "lorenarezende@gmail.com";
cliente02.Observacoes = "Filha do Josué e da Adriana.";
cliente02.ClienteAtivo = true;


//Cria e atribui informações ao cliente03
Cliente cliente03 = new();

cliente03.Nome = "Davi";
cliente03.Sobrenome = "Rezende Pena";
cliente03.Cpf = 98787454785;
DateTime.TryParseExact("24/12/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente03.DataAniversario);
cliente03.Profissao = "";
cliente03.ComoConheceu = "Pelos pais.";
cliente03.Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP - Brazil";
cliente03.Telefone = "1145862516";
cliente03.Celular = "1148789856";
cliente03.Email = "davirezendepena@gmail.com";
cliente03.Observacoes = "Filho do Julio e da Lorena.";
cliente03.ClienteAtivo = true;


//Cria e atribui informações ao cliente04
Cliente cliente04 = new();

cliente04.Nome = "Valderez";
cliente04.Sobrenome = "Gomes Pena";
cliente04.Cpf = 98745874589;
DateTime.TryParseExact("24/01/1963", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out cliente04.DataAniversario);
cliente04.Profissao = "Sócio-proprietária Fast Box";
cliente04.ComoConheceu = "Pelo filho Julio.";
cliente04.Endereco = "Rua De Portos, 232 apto 10 - Praça Nossa - Setúbal - Portugal";
cliente04.Telefone = "1145879856";
cliente04.Celular = "11981198881";
cliente04.Email = "valderezgpena@gmail.com";
cliente04.Observacoes = "Inativo por mudança de país.";
cliente04.ClienteAtivo = false;


//Cria grupo GoldPlus
Grupo goldPlus = new("Gold Plus Account");
{

    //goldPlus.NomeGrupo = "Gold Plus Account";
    goldPlus.Descricao = "Clientes com compra mensal acima de R$50.000,00";

}


//Cria grupo Gold
Grupo gold = new("Gold Account");
{

    //gold.NomeGrupo = "Gold Account";
    gold.Descricao = "Clientes com compra mensal acima de R$30.000,00";

}

//Cria grupo Silver Plus
Grupo silverPlus = new("Silver Plus Account");
{

    //silverPlus.NomeGrupo = "Silver Plus Account";
    silverPlus.Descricao = "Clientes com compra mensal acima de R$20.000,00";

}

//Cria grupo Silver
Grupo silver = new("Silver Account");
{

    //silver.NomeGrupo = "Silver Account";
    silver.Descricao = "Clientes com compra mensal acima de R$15.000,00";

}


//Adiciona clientes para o grupo GoldPlus
cliente01.VincularGrupo(gold);
cliente02.VincularGrupo(goldPlus);
cliente03.VincularGrupo(silverPlus);
cliente04.VincularGrupo(silver);


//Exibe cadastro
cliente01.ExibirCadastroCliente();
cliente02.ExibirCadastroCliente();
cliente03.ExibirCadastroCliente();
cliente04.ExibirCadastroCliente();