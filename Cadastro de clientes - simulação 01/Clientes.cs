class Cliente
{

    public string nome;
    public long cpf;
    public DateTime dataAniversario;
    public string profissão;
    public string comoConheceu;
    public string endereco;
    public long telefone;
    public long celular;
    public string email;
    public string observacoes;
    public DateTime dataInclusao = new DateTime();
    private bool clienteAtivo;

    public void RegistrarStatusCLiente(bool value)
    {

        clienteAtivo = value;

    }

    public bool ExibirStatusCliente()
    {

        return clienteAtivo;

    }

    public void ExibirCadastroCliente()
    {

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"CPF: {Convert.ToUInt64(cpf).ToString(@"000\.000\.000-00")}");
        Console.WriteLine($"Aniversário: {dataAniversario.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Profissão: {profissão}");
        Console.WriteLine($"Como nos conheceu: {comoConheceu}");
        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Telefone: {Convert.ToUInt64(telefone).ToString("(00)0000-0000")}");
        Console.WriteLine($"Celular: {Convert.ToUInt64(celular).ToString("(00)00000-0000")}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Observações: {observacoes}");
        Console.WriteLine($"Data de inclusão: {dataInclusao}");

        if(ExibirStatusCliente())
        {

            Console.WriteLine("Status: ativo\n\n");

        }
        else 
        {

            Console.WriteLine("Status: inativo\n\n");

        }

    }

}

