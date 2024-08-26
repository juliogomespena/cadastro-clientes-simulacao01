class Grupo
{

    public  int IdGrupo => GerarIdGrupo();

    public string NomeGrupo { get; set; }

    public string Descricao { get; set; }

    private int GerarIdGrupo()
    {

        Random random = new Random();

        return random.Next(1, 1000);

    }

}