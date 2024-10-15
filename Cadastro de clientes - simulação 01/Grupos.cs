class Grupo
{
    //Teste construtores
    public Grupo(string Nome)
    {
        NomeGrupo = Nome;
    }
    public  int IdGrupo => GerarIdGrupo();

    public string NomeGrupo { get; }

    public string Descricao { get; set; }

    private int GerarIdGrupo()
    {

        Random random = new Random();

        return random.Next(1, 1000);

    }

}