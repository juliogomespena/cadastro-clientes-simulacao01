using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Cliente
{

    public int IdCliente => GerarIdCliente();
    public Grupo Grupo { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public long Cpf { get; set; }

    public DateTime DataAniversario;
    public string Profissao { get; set; }
    public string ComoConheceu { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    public string Observacoes { get; set; }
    public bool ClienteAtivo { get; set; }
    public DateTime DataInclusao 
    {

        get
        {

            return DateTime.Now;

        }
    
    }
    public string NomeCompleto => $"{Nome} {Sobrenome}";


    public void ExibirCadastroCliente()
    {

        Console.WriteLine($"ID: {IdCliente}");
        Console.WriteLine($"Nome: {NomeCompleto}");
        Console.WriteLine($"CPF: {Convert.ToUInt64(Cpf).ToString(@"000\.000\.000-00")}");
        Console.WriteLine($"Nível da conta: {Grupo.IdGrupo} {Grupo.NomeGrupo}");
        Console.WriteLine($"Aniversário: {DataAniversario.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Profissão: {Profissao}");
        Console.WriteLine($"Como nos conheceu: {ComoConheceu}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Telefone: {Convert.ToUInt64(Telefone).ToString(@"(00)0000-0000")}");
        Console.WriteLine($"Celular: {Convert.ToUInt64(Celular).ToString(@"(00)0000-0000")}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Observações: {Observacoes}");
        Console.WriteLine($"Data de inclusão: {DataInclusao}");

        if(ClienteAtivo == true)
        {

            Console.WriteLine("Status: ativo\n\n");

        }
        else 
        {

            Console.WriteLine("Status: inativo\n\n");

        }

    }
    public int GerarIdCliente()
    {

        Random random = new Random();

        return random.Next(1, 1000);

    }
    public void VincularGrupo(Grupo grupo)
    {

        Grupo = grupo;

    }



    //se tornam desnecessários por conta das propriedades get set
    //public void RegistrarStatusCLiente(bool value)
    //{

    //    clienteAtivo = value;

    //}

    //public bool ExibirStatusCliente()
    //{

    //    return clienteAtivo;

    //}

}

