class Cliente
{

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public long Cpf { get; set; }

    public DateTime DataAniversario;
    public string Profissao { get; set; }
    public string ComoConheceu { get; set; }
    public string Endereco { get; set; }
    public long Telefone { get; set; }
    public long Celular { get; set; }
    public string Email { get; set; }
    public string Observacoes { get; set; }
    public bool ClienteAtivo { get; set; }

    //Modelo de escrita extensa:
    public DateTime DataInclusao 
    {

        get
        {

            return DateTime.Now;

        }
    
    }

    //Modelo de escrita concisa:
    public string NomeCompleto => $"{Nome} {Sobrenome}";



    public void ExibirCadastroCliente()
    {

        Console.WriteLine($"Nome: {NomeCompleto}");
        Console.WriteLine($"CPF: {Convert.ToUInt64(Cpf).ToString(@"000\.000\.000-00")}");
        Console.WriteLine($"Aniversário: {DataAniversario.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Profissão: {Profissao}");
        Console.WriteLine($"Como nos conheceu: {ComoConheceu}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Telefone: {Convert.ToUInt64(Telefone).ToString("(00)0000-0000")}");
        Console.WriteLine($"Celular: {Convert.ToUInt64(Celular).ToString("(00)00000-0000")}");
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

